using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Controllers
{
    //[ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : Controller
    {
        // REFACTOR: yet another instance of config that may need changing. This one is kinda important since this is the base API config used in all other controllers
        protected static readonly IConfiguration Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
        protected static readonly HttpClient client = new HttpClient();

        public BaseApiController()
        {

        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }

}
