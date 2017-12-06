using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Http.Features;

namespace APIGateway
{
  public class Startup
  {

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors(o => o.AddPolicy("APIGatewayPolicy", builder =>
      {
        builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
      }));
      services.Configure<FormOptions>(options => options.BufferBody = true);
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.Use((context, next) => { context.Request.EnableRewind(); return next(); });
      app.UseCors("APIGatewayPolicy");
      app.UseMvc();

    }
  }
}
