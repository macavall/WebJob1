using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJob1
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("myqueue")] string message, ILogger logger)
        {
            logger.LogInformation(message);
        }
    }
}
