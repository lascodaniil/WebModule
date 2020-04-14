using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Infrastructure
{
    public class ContentMiddleware
    {
        private RequestDelegate _delegate;
        public ContentMiddleware(RequestDelegate requestDelegate)
        {
            _delegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                if (httpContext.Request.Path.ToString().ToLower() == "/Index")
                {
                    await _delegate.Invoke(httpContext);
                }
            }
            catch (Exception e)
            {
                await httpContext.Response.WriteAsync("ERROR ROUTING IN MIDDLEWAE");
            }
        }
    }
}
