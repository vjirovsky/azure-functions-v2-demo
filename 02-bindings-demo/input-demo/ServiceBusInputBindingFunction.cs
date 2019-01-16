using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Dotnettalks.Function
{
    public static class ServiceBusInputBindingFunction
    {
        [FunctionName("ServiceBusInputBindingFunction")]
        public static void Run([ServiceBusTrigger("items-to-process", Connection = "dotnettalks-servicebus-playground_SERVICEBUS")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Process item from queue: '{myQueueItem}'");
        }
    }
}
