using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;

Host.CreateDefaultBuilder(args) //Creating own web server
    .ConfigureWebHostDefaults(webBuilder => //Creating web host with default settings
    {
        webBuilder.Configure(app => { 
            app.Run(async context => { //Whenever http request comes, execute this code
                //Simulate bad access of database due to blocking calls (almost takes 4 seconds for 100 requests)
                //Thread.Sleep(2000);
                //Task.Delay(2000).Wait();
                //Use Apache Benchmark Tool for Load Testing of Website, Even try to crash own server
                //Simulate good access of database (almost takes 2 seconds for 100 requests)
                await Task.Delay(TimeSpan.FromSeconds(10));
                await context.Response.WriteAsync("Hello World");
            });
        });
    }).Build().Run();
