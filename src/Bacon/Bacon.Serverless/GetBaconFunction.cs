using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Bacon.Serverless
{
    public static class GetBaconFunction
    {
        private static readonly List<string> BaconFlavors = new List<string>
        {
            "Slab Bacon",
            "Canadian Bacon",
            "Smoked Bacon"
        };

        [FunctionName("bacon-get")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "v1/bacon")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(BaconFlavors);
        }
    }
}
