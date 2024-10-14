using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using ServerApp.Models;
using Org.BouncyCastle.Ocsp;

namespace ServerApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public string Home()
        {
            return "";
        }
    }
    [ApiController]
    [Route("api/[controller]")]
    public class SigortaController : ControllerBase
    {
        private readonly string _connectionString = "server=localhost;user=root;password=admin;database=sigorta_db";

    [HttpPost()]
    [Route("post-data")]
    public IActionResult PostData([FromBody] FilterRequest filterRequest)
    {

        var results = new List<RequestModel>();

        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM sigortalar WHERE name LIKE @filter";
            
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@filter", $"%{filterRequest.Filter}%");
                using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new RequestModel
                            {
                                name = reader.GetString("name"),
                                email = reader.GetString("email"),
                                age = reader.GetInt32("age"),
                            };
                            results.Add(item);
                        }
                    }
            }
        }

        return Ok(new { message = "SORGULANDI", results });
     }
    }
        public class FilterRequest
    {
        public string? Filter { get; set; } // Kullanıcıdan gelen filtre
    }
}