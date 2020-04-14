using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace adocoreExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    DefaultFilesOptions options = new DefaultFilesOptions();

        //    options.DefaultFileNames.Clear();
        //    options.DefaultFileNames.Add("Default.html");
        //    app.UseDefaultFiles(options);


        //    app.UseMiddleware();

        //    app.Run(async (context) =>
        //    {
        //       await context.Response.WriteAsync("Hello World!");
        //    });









        public Startup()
        {
        }
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    app.UseStaticFiles();

        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Hello");
        //    });
        //}


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles(); // For the wwwroot folder

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                                    Path.Combine(Directory.GetCurrentDirectory(), @"Photo")),
                RequestPath = new PathString("/app-images")
            });
        }












        //if (env.IsEnvironment("Development"))
        //{
        //    // code to be executed in development environment 

        //}

        //if (env.IsDevelopment())
        //{
        //    // code to be executed in development environment 

        //}

        //if (env.IsStaging())
        //{
        //    // code to be executed in staging environment 

        //}

        //if (env.IsProduction())
        //{
        //    // code to be executed in production environment 

        //}











    }
    }

