using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apisampleproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        AppConfiguration AppConfiguration;

        public TestController(AppConfiguration appConfiguration)
        {
            AppConfiguration = appConfiguration;
        }

        [HttpGet]
        public string Get()
        {
            return AppConfiguration.ApiKey;
        }
    }
}
