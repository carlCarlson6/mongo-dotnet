using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MongoDotNet.Api.Middleware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate next;

        public LoggerMiddleware(RequestDelegate next) 
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("hello world!");

            await next(context);
        }
    }
}
