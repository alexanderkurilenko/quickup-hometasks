using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QuickUp.HomeTaks.Day2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using QuickUp.HomeTaks.Day3;
using QuickUp.HomeTaks.Day3.Logger;
using QuickUp.HomeTaks.Day3.Filters;

namespace QuickUp.HomeTaks
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        private IHostingEnvironment _env;
        public IConfiguration AppConfiguration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            AppConfiguration = builder.Build();
           
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyUniver;Integrated Security=True";
            services.AddDbContext<UniverContext>(options =>
            options.UseSqlServer(connection));
            services.AddMvc(options=>
            {
                options.Filters.Add(new TimeExecutionFilterAttribute());
                options.Filters.Add(typeof(CustomExeptionFilter));
            });
            services.AddDbContext<UniverContext>(options =>
            options.UseInMemoryDatabase());
            services.AddScoped<StudentRepository>();
            services.AddScoped<GroupRepository>();
            services.AddScoped<FileLoggerProvider>();
            services.AddScoped<ViewModel<Group>>();
            services.AddScoped<ViewModel<Student>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,StudentRepository context)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //context.Create(new Student { FirstMidName = "VAsua", GroupId = 2 });
        }
    }
}
