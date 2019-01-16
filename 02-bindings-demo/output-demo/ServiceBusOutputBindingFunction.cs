using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnettalks.Function
{
    public static class ServiceBusOutputBindingFunction
    {
        [FunctionName("ServiceBusOutputBindingFunction")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "create-order/")] HttpRequest req,
            [ServiceBus("items-to-process", Connection = "dotnettalks-servicebus-playground_SERVICEBUS", EntityType = EntityType.Queue)] ICollector<string> outputSbQueue,
            ILogger log)
        {
            string item = req.Query["item"];

            outputSbQueue.Add(item);

            return new OkObjectResult($"{item} added to queue.");

        }
    }
}
