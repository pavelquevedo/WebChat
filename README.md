# WebChat
WebChat using SignalR, EntityFramework, MVC, SQL Server and Azure Service Bus Messaging.

# Prerrequisites
You should have installed VS2019 with .NET Framework 4.7.2 (latest version 09/21/2021) with nuget package manager. 
Dependencies can be restored with right click on the solution, and selecting "Restore nuget packages".

# Dependencies
These are the nuget packages installed manually in each solution.

**WebChat.Api**
* Microsoft.AspNet.SignalR v3.2.7 
* Microsoft.IdentityModel.Tokens v6.12.2
* Microsoft.Owin.Cors v4.2.0
* Newtonsoft.Json v12.0.2
  
**WebChat.Client**
* Microsoft.AspNet.SignalR v3.2.7
* Newtonsoft.Json v12.0.2
* RestSharp v106.12.0

**WebChat.Utils**
* LumenWorksX.Framework.IO v1.0.1 
* Microsoft.Azure.ServiceBuse v.5.1.3 

# Local Installation
These are the steps you must follow if you want to run the project locally.

1. Restore nuget packages.
2. By default I left the api connection strings references pointing to the published api. If you want to point the application to the local api, 
these are te places where you have to change it:
  - WebChat.Api\Web.config\appSettings - JWT_AUDIENCE_TOKEN, JWT_ISSUER_TOKEN
  - WebChat.Api.Test\App.config\appSettings - JWT_AUDIENCE_TOKEN, JWT_ISSUER_TOKEN, api_url
  - WebChat.Client\Web.config\appSettings - api_url
3. Run the solution.

Thank you for reading, enjoy!

 
  

