using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Infrastructure
{
    public class ResponseMiddleware
    {
        private RequestDelegate _delegate;
        public ResponseMiddleware(RequestDelegate requestDelegate)
        {
            _delegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Response.StatusCode == 200)
            {
                await httpContext.Response.WriteAsync("SUCCESS");
            }
            else
            {
                await httpContext.Response.WriteAsync("ERROR");
            }
        }

    }
}
