using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Logger
{
    public static class Configuration
    {

        public static string Path()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration appConfiguration = builder.Build();
            return appConfiguration["Filepath"];
        }
       

    }
}
