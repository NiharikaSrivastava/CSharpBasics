using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Host.CreateDefaultBuilder(args) //Creating own web server
    .ConfigureWebHostDefaults(webBuilder => //Creating web host with default settings
    {
        webBuilder.Configure(app => { 
            app.Run(async context => { //Whenever http request comes, execute this code
                await context.Response.WriteAsync("Hello World");
            });
        });
    }).Build().Run();
