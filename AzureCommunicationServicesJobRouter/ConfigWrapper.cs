using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter
{
    internal class ConfigWrapper
    {
        private readonly IConfiguration _config;

        public ConfigWrapper(IConfiguration config)
        {
            _config = config;

            AcsConnectionString = _config["AcsConnectionString"];
            ServiceBusQueueName = _config["ServiceBusQueueName"];
            ServiceBusEntraIdClientId = _config["ServiceBusEntraIdClientId"];
            ServiceBusEntraIdClientSecret = _config["ServiceBusEntraIdClientSecret"];
            TenantId = _config["TenantId"];
            ServiceBusfullyQualifiedNamespace = _config["ServiceBusfullyQualifiedNamespace"];
        }

        public string AcsConnectionString { get; private set; }

        public string ServiceBusQueueName { get; private set; }

        public string ServiceBusfullyQualifiedNamespace { get; private set; }

        public string TenantId { get; private set; }

        public string ServiceBusEntraIdClientId { get; private set; }

        public string ServiceBusEntraIdClientSecret { get; private set; }
    }
}
