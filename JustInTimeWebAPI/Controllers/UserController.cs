using Microsoft.AspNetCore.Mvc;

namespace JustInTimeWebAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
/*
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Steeltoe.Common.Discovery;
using System.Net.Http;
using System.Threading.Tasks;

namespace JustInTimeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly DiscoveryHttpClientHandler _handler;

        public UserController(ILogger<UserController> logger, IDiscoveryClient client)
        {
            _logger = logger;
            _handler = new DiscoveryHttpClientHandler(client);
        }

        // GET api/user
        [HttpGet]
        public async Task<string> Get()
        {
            var client = new HttpClient(_handler, false);
            return await client.GetStringAsync("http://EurekaRegisterExample/api/WeatherForecast");
        }
    }
}
*/