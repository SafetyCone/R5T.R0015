using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace R5T.R0015.Construction.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StringsController : ControllerBase
    {
        [HttpGet("values")]
        public async Task<string[]> Get()
        {
            // Simulate a long operation.
            await Task.Delay(3000);

            var output = new string[]
            {
            "A",
            "B",
            "C"
            };

            return output;
        }
    }
}