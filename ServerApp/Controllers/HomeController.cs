using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

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
}