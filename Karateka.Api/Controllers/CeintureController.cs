using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Karateka.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CeintureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Blanche", "Jaune", "Orange", "Verte", "Bleue", "Brune", "Shodan", "Nidan", "Sandan", "Yodan"
        };

        private readonly ILogger<CeintureController> _logger;

        public CeintureController(ILogger<CeintureController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ceinture> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 9).Select(index => new Ceinture
            {
                Color = Summaries[index],
                Level = index,
            })
            .ToArray();
        }
    }
}
