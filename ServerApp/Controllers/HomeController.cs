using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    public class HomeController : Controller
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

                // SQL sorgusunu düzenledik
               string query = "SELECT aracMarka, modelYil, model, aracPaketi, yakitTipi, fiyat, sirketAdi " +
                                "FROM sigortalar " +
                                "WHERE modelYil = @modelYil " +
                                "AND model = @model " +
                                "AND aracPaketi = @aracPaketi " +
                                "AND yakitTipi = @yakitTipi " + // Boşluk eklendi
                                "AND aracMarka = @aracMarka"; // Boşluk eklendi


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@modelYil", filterRequest.modelYil);
                    command.Parameters.AddWithValue("@model", filterRequest.model);
                    command.Parameters.AddWithValue("@aracPaketi", filterRequest.aracPaketi);
                    command.Parameters.AddWithValue("@yakitTipi", filterRequest.yakitTipi);
                    command.Parameters.AddWithValue("@aracMarka", filterRequest.aracMarka);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new RequestModel
                            {
                                aracMarka = reader.GetString("aracMarka"),
                                modelYil = reader.GetInt32("modelYil"),
                                model = reader.GetString("model"),
                                aracPaketi = reader.GetString("aracPaketi"),
                                yakitTipi = reader.GetString("yakitTipi"),
                                fiyat = reader.GetDecimal("fiyat"),
                                sirketAdi = reader.GetString("sirketAdi")
                            };
                            results.Add(item);
                        }
                    }
                }
            }
            return Ok(new { message = "SORGULANDI", results });
        }
        [HttpGet()]
        [Route("get-data")]
        public List<RequestModel> GetAraclar()
        {
            var results = new List<RequestModel>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
               string query = "SELECT DISTINCT * FROM sigortalar";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new RequestModel
                            {
                                aracMarka = reader.GetString("aracMarka"),
                                modelYil = reader.GetInt32("modelYil"),
                                model = reader.GetString("model"),
                                aracPaketi = reader.GetString("aracPaketi"),
                                yakitTipi = reader.GetString("yakitTipi"),
                                fiyat = reader.GetDecimal("fiyat"),
                                sirketAdi = reader.GetString("sirketAdi")
                            };
                            results.Add(item);
                        }
                    }
                }
            }
            return results;
        }
        [HttpGet()]
        [Route("get-marka-model")]
        public List<AracMarkaModel> GetAracMarkaModel()
        {
            var results = new List<AracMarkaModel>();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT aracMarka, model FROM sigortalar";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new AracMarkaModel
                            {
                                aracMarka = reader.GetString("aracMarka"),
                                aracModel = reader.GetString("model"),
                            };
                            results.Add(item);
                        }
                    }
                }
            }
            return results;
        }
        [HttpGet()]
        [Route("get-model-yil")]
        public List<AracModelYil> GetAracModelYil()
        {
            var results = new List<AracModelYil>();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT aracMarka, model, modelYil FROM sigortalar";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new AracModelYil
                            {
                                aracModelYil = reader.GetInt32("modelYil"),
                                aracMarka = reader.GetString("aracMarka"),
                                aracModel = reader.GetString("model"),
                            };
                            results.Add(item);
                        }
                    }
                }
            }
            return results;
        }
        [HttpGet()]
        [Route("get-aracpaketi-yakittipi")]
        public List<AracPaketiYakitTipi> GetAracPaketiYakitTipi()
        {
            var results = new List<AracPaketiYakitTipi>();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT aracPaketi,yakitTipi,model,aracMarka,modelYil FROM sigortalar";
                using(MySqlCommand command = new MySqlCommand(query,connection))
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new AracPaketiYakitTipi
                            {
                                aracPaketi = reader.GetString("aracPaketi"),
                                yakitTipi = reader.GetString("yakitTipi"),
                                aracModel = reader.GetString("model"),
                                aracMarka = reader.GetString("aracMarka"),
                                modelYil = reader.GetInt32("modelYil")
                            };
                            results.Add(item);
                        }
                    }
                }
            }
            return results;
        }
    }

    public class FilterRequest
    {
        public string? model { get; set; }
        public string? aracMarka { get; set; }
        public string? aracPaketi { get; set; }
        public string? yakitTipi { get; set; }
        public int modelYil { get; set; }
    }
}
