using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System.Runtime.Serialization;
using APIGateway.Requests;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIGateway.Controllers
{
    [Route("api/[controller]")]
    public class ModuleConfigController : Controller
    {
       
      
        // GET: api/values
        [HttpGet]        
        [EnableCors("APIGatewayPolicy")]
        public string Get()
        {            
            return EquipmentRequests.GetAllEquipment().Result;
        }

        [HttpGet("{id}")]
        [EnableCors("APIGatewayPolicy")]
        public string Get(Guid id)
        {
            return EquipmentRequests.Get(id).Result;

        }


    }
}
