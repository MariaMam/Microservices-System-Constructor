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
    [ApiVersion("1.0")]
    public class EquipmentController : Controller
    {
       
        [HttpGet]        
        [EnableCors("APIGatewayPolicy")]
        public string Get()
        {            
            return EquipmentRequests.GetAllEquipment("api-version=1.0").Result;
        }

        [HttpGet("{id}")]
        [EnableCors("APIGatewayPolicy")]
        public string Get(string id)
        {
            return EquipmentRequests.Get(id, "api-version=1.0").Result;

        }


    }
}
