using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Hypertextor
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Run(context => context.Response.WriteAsync("Hypertextor"));
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }
    }
}
