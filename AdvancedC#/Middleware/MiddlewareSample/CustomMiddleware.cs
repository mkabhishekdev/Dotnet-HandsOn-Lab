using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareSample
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAync(HttpContext context)
        {
            // do something before
            await _next(context);
            // do something after
        }

    }
}