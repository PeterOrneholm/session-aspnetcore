using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MyWebappCore.Controllers
{
    public class InfoController : Controller
    {
        private readonly IConfiguration _configuration;

        public InfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("api/info/version")]
        public string GetVersion()
        {
            return _configuration["NetVersion"];
        }

        [Route("api/info/machine")]
        public string GetMachine()
        {
            return Environment.MachineName;
        }
    }
}