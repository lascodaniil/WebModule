using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Infrastructure
{
    public class ShortMiddleware
    {
        private RequestDelegate _delegate;
        public ShortMiddleware(RequestDelegate requestDelegate)
        {
            _delegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Cookies.Count==0)
            {
                httpContext.Response.StatusCode = 200;
                await _delegate.Invoke(httpContext);
            }
            else
            {
                httpContext.Response.StatusCode = 403;
            }
        }

    }
}
