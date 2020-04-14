﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace adocoreExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
         
                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseWebRoot("Dinesh")
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
            

            host.Run();
            }
        }


    }

