using dotnetservice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetservice.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ILogger _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ping")]
        public PongMessage Ping(string message)
        {
            _logger.LogInformation("Got ping request. Message: {}", message);
            return new PongMessage(message);
        }
    }
}