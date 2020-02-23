using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PruebaTecnica.Controllers;
using PruebaTecnica.Models;

namespace PruebaTecnica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read File
            using (TextFile fileT = new TextFile($@"{Directory.GetCurrentDirectory()}/Utils/", "dataset.txt"))
            {
                // Assign the list of people to controller
                PersonController.setPersons(fileT.LoadFile());
            }

            //using (JsonFile fileJ = new JsonFile($@"{Directory.GetCurrentDirectory()}/Utils/", "dataset.json"))
            //{
            //    PersonController.setPersons(fileJ.LoadFile());
            //}

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                });
    }
}
