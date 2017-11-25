using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EquipmentAPIService.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace EquipmentAPIService
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
      //var connection = @"Server=MMPC\MMSERVER;Database=EquipmentDB;Trusted_Connection=True;";
      //services.AddDbContext<EquipmentDBContext>(options => options.UseSqlServer(connection));
      services.AddApiVersioning();
      services.AddCors(o => o.AddPolicy("EquipmentPolicy", builder =>
            {
              builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
            }));
      services.AddScoped<IEquipmentRepository, EquipmentRepository>();

      services.AddDbContext<EquipmentDBContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("EquipmentDB"));
        options.ConfigureWarnings(warnings => warnings.Throw(
        RelationalEventId.QueryClientEvaluationWarning));
      });
      services.AddMvc();
    }



    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseCors("EquipmentPolicy");
      app.UseMvc();
    }
  }
}
