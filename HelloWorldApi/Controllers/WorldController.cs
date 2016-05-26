using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using HelloWorldApi.Models;

namespace HelloWorldApi.Controllers
{
    public class WorldController : ApiController
    {
        public WorldController()
        {
        }

        [HttpGet]
        public World Get()
        {
            return new World
            {
                Greeting = "Hello"
            };
        }
    }
}