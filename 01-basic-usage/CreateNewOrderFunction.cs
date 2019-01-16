using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DotnetTalks.Function
{
    public static class CreateNewOrderFunction
    {
        [FunctionName("CreateNewOrderFunction")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "create-order/")] HttpRequest req,
            ILogger log)
        {

            log.LogInformation("CreateNewOrderFunction - function started");

            if (String.IsNullOrEmpty(req.Query["productId"]))
            {
                return new BadRequestObjectResult("Argument {productId} missing.");
            }
            
            if (String.IsNullOrEmpty(req.Query["amount"]))
            {
                return new BadRequestObjectResult("Argument {amount} missing.");
            }
            
            if (String.IsNullOrEmpty(req.Query["email"]))
            {
                return new BadRequestObjectResult("Argument {email} missing.");
            }


            int productId = Int32.Parse(req.Query["productId"]);
            int amount = Int32.Parse(req.Query["amount"]);
            string email = req.Query["email"];

            return new OkObjectResult($"Product ID {productId} x {amount} pcs ordered for email '{email}'.");
        }
    }
}
