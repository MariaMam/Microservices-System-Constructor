using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquipmentAPIService.Models;
using Microsoft.AspNetCore.Cors;
using EquipmentAPIService.NewFolder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EquipmentAPIService.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  public class EquipmentController : Controller
  {
    public EquipmentController(IEquipmentRepository equipmentItems)
    {
      EquipmentItems = equipmentItems;
    }
    public IEquipmentRepository EquipmentItems { get; set; }
    // GET: api/values
    [HttpGet]
    [EnableCors("EquipmentPolicy")]
    public IEnumerable<EquipmentItemTable> Get()
    {
      return EquipmentItems.GetAll().Select(x => new EquipmentItemTable { AssetNumber = x.AssetNumber, Name = x.Name, EquipmentItemId = x.EquipmentItemId });
    }

    // GET api/values/5
    [HttpGet("{id}")]
    [EnableCors("EquipmentPolicy")]
    public TblEquipmentItem Get(Guid id)
    {
      return EquipmentItems.FindByID(id);

    }
    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    [HttpPost]
    public IActionResult Create([FromBody] TblEquipmentItem item)
    {
      if (item == null)
      {
        return BadRequest();
      }
      EquipmentItems.Add(item);
      return CreatedAtRoute("GetTodo", new { id = item.EquipmentItemId }, item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] TblEquipmentItem item)
    {
      if (item == null || item.EquipmentItemId != id)
      {
        return BadRequest();
      }

      var equipmentItem = EquipmentItems.FindByID(id);

      if (equipmentItem == null)
      {
        return NotFound();
      }

      EquipmentItems.Update(item);
      return new NoContentResult();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
      var todo = EquipmentItems.FindByID(id);
      if (todo == null)
      {
        return NotFound();
      }

      EquipmentItems.Remove(id);
      return new NoContentResult();
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
