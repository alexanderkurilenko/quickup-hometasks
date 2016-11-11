using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using QuickUp.HomeTaks.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Filters
{
    public class WrappFilterAttribute :  Attribute,IResultFilter
    {
        string _result;
        DateTime _time;
        public WrappFilterAttribute(string result)
        {
            _result = result;
            _time = DateTime.Now;
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public async void OnResultExecuting(ResultExecutingContext context)
        {
            await context.HttpContext.Response.WriteAsync(_result+_time.ToString());
        }
    }
}
