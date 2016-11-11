using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Filters
{
    public class TimeExecutionFilterAttribute : Attribute, IResultFilter
    {
        DateTime start;
        public   void OnResultExecuting(ResultExecutingContext context)
        {
          
        }
        public async void OnResultExecuted(ResultExecutedContext context)
        {
            start = DateTime.Now;
            await context.HttpContext.Response.WriteAsync($"Server Time:" + start.ToString());
        }
    }
}
