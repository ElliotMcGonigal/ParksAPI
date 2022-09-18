# State and National Parks API
#### Project by Elliot McGonigal
## Description
This API will give info on a few of the state and national parks
## Technologies Used
* C#
* MSTest
* .NET 5.0
* ASP.NET Core MVC
* Html
* MySql Workbench
* Swagger
* API
## Setup
1. Set up your environment. I use GitBash with VSCode for this. You'll also want MySql Workbench installed.
2. Install .NET https://dotnet.microsoft.com/en-us/download/dotnet/5.0 get .NET SDK 5.0.408
3. Clone this repo by entering into GitBash 'git clone https://github.com/ElliotMcGonigal/ParksAPI'
4. In the terminal, navigate to the file you just cloned.
5. Create an 'appsettings.json' file in the ParksAPI directory. It should look like the following: 
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAME HERE];uid=[YOUR USER ID HERE];pwd=[YOUR PASSWORD HERE];"
  }
}
6. Have mysql server running and open mysql workbench
7. Enter 'dotnet build' into the terminal
8. Enter 'dotnet run' into the terminal
9. Enter 'dotnet ef database update' into the terminal
10. Now open a browser and go to http://localhost:5003/api/Parks and see the data, or go to http://localhost:5003/swagger to view it with swagger. To see more of what you can do with swagger check out https://swagger.io/tools/swagger-ui/
## Known Bugs
The Views were intended to help see what I'm doing and add to the database, however that isn't fully implemented yet. Swagger is implemented, albeit with very little use yet.
## License
GNU gpl 3.0 view LICENSE for more details