# Azure Communication Services Job Router Visualization Tool
This is an unofficial tool to test the [Azure Communication Services Job Router](https://learn.microsoft.com/en-us/azure/communication-services/concepts/router/concepts). It will help you visualize the job router compoents, including distribution policieis, queues, workers, and jobs.


## Prerequisites
To run this tool, you need to have the following:
+ An [Azure Communication Services](https://learn.microsoft.com/en-us/azure/communication-services/overview) resource. You can create the resource by following the steps mentioned here [Job Router Prerequesets](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/router/get-started-router?pivots=programming-language-csharp#prerequisites).
+ An [Azure Service Bus](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview) resource with a namespace and queue. You can create the resource by following the public documentation on how to [Use Azure portal to create a Service Bus namespace and a queue](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quickstart-portal).
+ .Net 8.0. You can download it from [.Net download page](https://dotnet.microsoft.com/en-us/download/dotnet).


## Before You Run
After downloading the project and building it using Visual Studio, you need to prepare your environment as follows:
+ Configure your Azure Communication Services resource events to send all Job Router-related events to the Azure Service Bus queue created in the prerequisites. For more information on setting up the events, refer to the [Subscribe to Azure Communication Services events](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp) documentation.
+ Register an Entra App application and grant it access to the Service Bus. This application will be used to fetch the notifications from the Service Bus queue. For more infomration about how to register an application and create a client secret you can check this document [Add and manage application credentials in Microsoft Entra ID](https://learn.microsoft.com/en-us/entra/identity-platform/how-to-add-credentials?tabs=client-secret)
+ Modify the `app.config` file inside your project with the following details:
    + `AcsConnectionString`: Your Azure Communication Services resource connection string.
    + `ServiceBusQueueName`: Your Azure Service Bus created queue name.
    + `ServiceBusfullyQualifiedNamespace`: Your Service Bus fully qualified namespace (Host name). Usually it will be like <i>{Service_Bus_Namespace}.servicebus.windows.net</i>.
    + `TenantId`: Your Azure tenant Id.
    + `ServiceBusEntraIdClientId`: Registerd Entra App client Id.
    + `ServiceBusEntraIdClientSecret`: Registered Entra App client secret.

 
## Notes
+ **This is an unofficial tool that you can use to test the Azure Communication Services Job Router. Use it at your own risk, as there are no guarantees that it is bug-free.**
+ Depending on your tenant security rules, you might need to make sure that the Event Grid is using the System Assigned or User Assigned Managed Identity to deliver the notifications. In this case, please makse sure that the Event Grid System Topic has sufficient permissions to access the Service Bus. You can select either `Azure Service Bus Data Owner` or `Azure Service Bus Data Sender`. You can find more infomration here [Use managed identities to deliver events in Azure Event Grid](https://learn.microsoft.com/en-us/azure/event-grid/managed-service-identity)
+ The tool includes several shortcuts for your convenience. For example:
    + You can click on `Options` and then `Refresh` (`CTRL + R`) to manually refresh the lists.
    + You can click on `Options` and then `Legend` (`CTRL + L`) to display the legend window.
    + You can click on `Options` and then `Create Testing Data` (`CTRL + T`) to create a testing Distribution Policy, Queue, Worker, and Job.
+ Some features, such as `Job Matching` Mode and `Classification Policies`, are currently missing but will be added later. However, this will not affect the tool's usability, as these features are optional.


## Key Features
This tool will help you test the Azure Communication Services Job Router by providing the following key features:
+ It visualizes the Job Router components for you, allowing you to see them in tables and understand the relationships between them.
+ You can create and update Distribution Policies, Queues, Workers, and Jobs.
+ It colors the row backgrounds with different colors to make it easier to track changes in component states.
+ It displays different Job Router events based on actions, giving you a better understanding of when events are fired and what information each one contains.
+ You can use it as a proof of concept (POC) to build your distribution policy and workers, and test how jobs will be distributed in different scenarios.
+ The `JobRouterEventParser` project contains a parser for most of the Job Router events (remaining events will be added later), which can be useful if you need a parser.
+ The `ServiceBusReceiver` project is a Service Bus consumer that you can use as a starting point for any other project or service where you need to consume Service Bus events.
+ It helps you test moving components between different states, and provides descriptive error messages if you try to move between unsupported states.
+ You can easily create testing data by simply clicking on `Options` and then `Create Testing Data`.

## Breaking Changes
<ul>
  <li><b>Version 1.3 - Nov 2025:</b></li>
 <ul>
  <li><i>ServiceBusConnectionString</i> has been replaced with <i>ServiceBusfullyQualifiedNamespace</i>, <i>TenantId</i>, <i>ServiceBusEntraIdClientId</i> and <i>ServiceBusEntraIdClientSecret</i> so the authentication to the Service Bus is being handled by Entra App rather than connection string</li>   
 </ul>
</ul>

## Reporting Bugs and Suggesting Feature Requests
If you encounter any bugs while using the tool or have any feature requests, please open a [new issue](https://github.com/ealmuneyeer/AzureCommunicationServicesJobRouter/issues/new) on GitHub.
