using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using ModuleConfiguration.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModuleConfiguration.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [EnableCors("ModueConfigurationPolicy")]
  public class ModuleConfigurationController : Controller
  {
    public IModuleConfigurationRepository ControlConfigs { get; set; }

    public ModuleConfigurationController(IModuleConfigurationRepository controlConfigs)
    {
      ControlConfigs = controlConfigs;
    }

    /*[HttpGet("GetByModule")]
    [EnableCors("ModueConfigurationPolicy")]
    public List<TblModuleControlConfig> Get(string module)
    {
      return ControlConfigs.GetforModule(module);

    }*/

    [HttpGet]
    [EnableCors("ModuleConfigurationPolicy")]
    public List<TblModuleControlConfig> Get()
    {
      return ControlConfigs.Get();

    }

    [HttpGet("GetByModule")]
    [EnableCors("ModuleConfigurationPolicy")]
    public string Get(string module)
    {
      return JsonConvert.SerializeObject(ControlConfigs.GetforModule(module));

    }

    [HttpGet("GetModuleSettings")]
    [EnableCors("ModuleConfigurationPolicy")]
    public string GetModuleSettings(string module)
    {
      var result1 = ControlConfigs.GetModuleSettings(module);
      Console.WriteLine(result1);
      var result = JsonConvert.SerializeObject(ControlConfigs.GetModuleSettings(module));
      Console.WriteLine(result);
      return result;

    }

  }
}
