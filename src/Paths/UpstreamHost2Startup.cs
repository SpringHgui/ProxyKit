﻿using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ProxyKit.Recipe.Simple
{
    public class UpstreamHost2Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                var html = new StringBuilder("<!DOCTYPE html><html><body><h2>Hello from upstream host 2!</h2>");
                html.Append(context.Request.AsHtml());
                html.Append("</body></html>");
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync(html.ToString());
            });
        }
    }
}