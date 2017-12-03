using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using APIGateway.Requests;
using System.IO;
using System.Runtime.Serialization.Json;
using APIGateway.Models.Configuration;
using Newtonsoft.Json.Linq;
using APIGateway.ServiceClasses;

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
      switch (module)
      {
        case "31":
          var result = ModuleConfigRequests.GetModuleConfigByModule("Equipment", "api-version=1.0");
          var result2 = result.Result;
          return ModuleConfigRequests.GetModuleConfigByModule("Equipment", "api-version=1.0").Result;
        default:
          return "Bad Request";
          break;
      }
    }

    [HttpGet("GetCntrlsWithValues")]
    [EnableCors("APIGatewayPolicy")]
    public string GetCntrlsWithValues(string module, string entityId)
    {
      switch (module)
      {
        case "31":
          var configs = ModuleConfigRequests.GetCntrlsWithValues("Equipment", "api-version=1.0");          
          JArray json = ConfigurationParser.ParseResponse(configs.Result);
          for (int i = 0; i < json.Count; i++)
          {            
            Column column = new Column(json[0]["columnName"].ToString());
            if (column.TableName == "TBL_EquipmentItem")
            {
              var record = ConfigurationParser.ParseResponseObject(EquipmentRequests.Get(entityId, "api-version=1.0").Result);
              json[i]["value"] = record[column.ColumnName];
            }

          }
          return json.ToString();

        default:
          return "Bad Request";
          break;
      }
    }

    [HttpGet("GetModuleSettings")]
    [EnableCors("APIGatewayPolicy")]
    public string GetModuleSettings(string module)
    {
     
          return ModuleConfigRequests.GetModuleSettings(module, "api-version=1.0").Result;       
      
     
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost("SaveModuleSettings")]
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
