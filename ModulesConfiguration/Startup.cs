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
using ModuleConfiguration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Internal;

namespace ModulesConfiguration
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
      services.AddApiVersioning();
      services.AddCors(o => o.AddPolicy("ModuleConfigurationPolicy", builder =>
      {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
      }));
      services.AddScoped<IModuleConfigurationRepository, ModuleConfigurationRepository>();

      services.AddDbContext<ModuleConfigurationContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("ModuleConfiguration"));        
        options.ConfigureWarnings(warnings => warnings.Throw(
        RelationalEventId.QueryClientEvaluationWarning));
      });
      services.Configure<FormOptions>(options => options.BufferBody = true);
      //Receiver.Receive();
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
      app.UseMvc();
    }
  }
}
