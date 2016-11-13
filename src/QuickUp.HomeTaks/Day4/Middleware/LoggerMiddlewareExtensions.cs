using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day4
{
    public static class LoggerMiddlewareExtensions
    {
        public static IApplicationBuilder MapRLogger(this IApplicationBuilder builder)
        {
            return  builder.UseMiddleware<LoggerMiddleware>();
        }

    }
}
