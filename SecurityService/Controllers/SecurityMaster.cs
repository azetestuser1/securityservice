using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SecurityService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecurityMasterController : ControllerBase
    {

        private readonly ILogger<SecurityMasterController> _logger;

        public SecurityMasterController(ILogger<SecurityMasterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public SecurityData Get()
        {
            var rng = new Random();
            return new SecurityData {
                UpdateDate = DateTime.Now,
                SecurityName = "Apple Inc",
		AssetClass = "EQUITY",
		Ticker = "AAPL"
            };
        }
    }
}
