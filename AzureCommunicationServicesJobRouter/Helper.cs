using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter
{
    internal class Helper
    {
        public class ValueType
        {
            public const string Number = "Number";
            public const string String = "String";
            public const string Boolean = "Boolean";
        }

        public static string MaskConnectionString(string connectionString)
        {
            string[] keysToMask = { "accesskey=", "SharedAccessKey=" };

            List<string> parts = connectionString.Split(';').ToList();

            for (int i = 0; i < parts.Count; i++)
            {
                foreach (var keyToMask in keysToMask)
                {
                    if (parts[i].StartsWith(keyToMask, StringComparison.InvariantCultureIgnoreCase))
                    {
                        parts[i] = parts[i].Substring(0, keyToMask.Length + 3) + "***";
                    }
                }
            }

            return string.Join(';', parts);
        }

        public static string MaskSecret(string secret)
        {
            return secret.Substring(0, 3) + "***";
        }

        public static string GetApplicationVersion()
        {
            return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString(3);
        }

        public static string GetUniqueId()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static List<RouterWorkerSelector> GetJobDefaultRequestedWorkerSelectors()
        {
            return new List<RouterWorkerSelector>
            {
                { new RouterWorkerSelector("TechSkills", LabelOperator.GreaterThan, new RouterValue(10))}
            };
        }

        public static Dictionary<string, RouterValue> GetWorkerDefaultLabels()
        {
            return new Dictionary<string, RouterValue>
            {
                { "TechSkills", new RouterValue(11) }
            };
        }

        public static string GetValueTypeString(string key, object value)
        {
            if (value is int)
            {
                return ValueType.Number;
            }
            else if (value is string)
            {
                return ValueType.String;
            }
            else if (value is bool)
            {
                return ValueType.Boolean;
            }
            else
            {
                throw new ArgumentOutOfRangeException(key, value, $"Value is out of range. Expected values are: Number, String, and Boolean");
            }
        }

        public static RouterValue GetRouterValue(string key, string value, string valueType)
        {
            switch (valueType)
            {
                case ValueType.Number:
                    return new RouterValue(Convert.ToInt32(value));

                case ValueType.String:
                    return new RouterValue(value);

                case ValueType.Boolean:
                    return new RouterValue(Convert.ToBoolean(value));

                default:
                    throw new ArgumentOutOfRangeException(key, value, "Value is out of range. Expected values are: Number, String, and Boolean");
            }
        }

        public static KeyValuePair<string, RouterValue> GetRouterValueEntry(string name, string value, string valueType)
        {
            return new KeyValuePair<string, RouterValue>(name, Helper.GetRouterValue(name, value, valueType));
        }

        public static DistributionPolicy GetTestingDistributionPolicy(string uniqueId)
        {
            return new DistributionPolicy($"testDistPolicy-{uniqueId}")
            {
                Name = $"Test Distribution Policy {uniqueId}",
                OfferExpiresAfter = TimeSpan.FromSeconds(60),
                Mode = new LongestIdleMode(),
            };
        }

        public static RouterQueue GetTestingQueue(DistributionPolicy distPolicy, string uniqueId)
        {
            return new RouterQueue("testQueue-" + uniqueId)
            {
                Name = "Test Queue " + uniqueId,
                DistributionPolicyId = distPolicy.Id,
            };
        }

        public static RouterWorker GetTestingWorker(RouterQueue queue, string uniqueId)
        {
            RouterWorker routerWorker = new RouterWorker($"testWorker-{uniqueId}")
            {
                AvailableForOffers = true,
                Capacity = 1,
                MaxConcurrentOffers = 1,
            };

            routerWorker.Queues.Add(queue.Id);

            foreach (var label in GetWorkerDefaultLabels())
            {
                routerWorker.Labels.Add(label);
            }

            routerWorker.Channels.Add(new RouterChannel($"testChannel-{uniqueId}", 1));

            return routerWorker;
        }

        public static RouterJob GetTestingJob(RouterWorker worker, string uniqueId)
        {

            RouterJob routerJob = new RouterJob($"testJob-{uniqueId}")
            {
                ChannelId = worker.Channels.First().ChannelId,
                QueueId = worker.Queues.First(),
                Priority = 1,
            };

            foreach (var selector in GetJobDefaultRequestedWorkerSelectors())
            {
                routerJob.RequestedWorkerSelectors.Add(selector);
            }

            return routerJob;
        }
    }

}
