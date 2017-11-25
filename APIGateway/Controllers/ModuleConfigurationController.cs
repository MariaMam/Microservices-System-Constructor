using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using APIGateway.Requests;

namespace APIGateway.Controllers
{
  [Route("api/[controller]")]
  [ApiVersion("1.0")]
  [EnableCors("APIGatewayPolicy")]
  public class ModuleConfigurationController : Controller
  {
    // GET: api/values
    [HttpGet]
    [EnableCors("APIGatewayPolicy")]
    public string Get()
    {
      return ModuleConfigRequests.GetAll().Result;
    }

    [HttpGet("GetByModule")]
    [EnableCors("APIGatewayPolicy")]
    public string Get(string module)
    {
      return ModuleConfigRequests.GetModuleConfigByModule(module, "api-version=1.0").Result;


    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
