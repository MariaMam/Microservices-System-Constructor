using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipmentAPIService.Models;

namespace EquipmentAPIService.Controllers
{
    [Produces("application/json")]
    [Route("api/TblEquipmentItems")]
    [Route("api/[controller]")]
    public class TblEquipmentItemsController : Controller
    {
        private readonly EquipmentDBContext _context;

        
        public TblEquipmentItemsController(EquipmentDBContext context)
        {
            _context = context;
        }

        // GET: api/TblEquipmentItems1
        [HttpGet]
        public IEnumerable<TblEquipmentItem> GetTblEquipmentItems()
        {
            return _context.TblEquipmentItem;
        }

        // GET: api/TblEquipmentItems1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTblEquipmentItem([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblEquipmentItem = await _context.TblEquipmentItem.SingleOrDefaultAsync(m => m.EquipmentItemId == id);

            if (tblEquipmentItem == null)
            {
                return NotFound();
            }

            return Ok(tblEquipmentItem);
        }

        // PUT: api/TblEquipmentItems1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblEquipmentItem([FromRoute] Guid id, [FromBody] TblEquipmentItem tblEquipmentItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblEquipmentItem.EquipmentItemId)
            {
                return BadRequest();
            }

            _context.Entry(tblEquipmentItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblEquipmentItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TblEquipmentItems1
        [HttpPost]
        public async Task<IActionResult> PostTblEquipmentItem([FromBody] TblEquipmentItem tblEquipmentItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TblEquipmentItem.Add(tblEquipmentItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblEquipmentItemExists(tblEquipmentItem.EquipmentItemId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblEquipmentItem", new { id = tblEquipmentItem.EquipmentItemId }, tblEquipmentItem);
        }

        // DELETE: api/TblEquipmentItems1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblEquipmentItem([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblEquipmentItem = await _context.TblEquipmentItem.SingleOrDefaultAsync(m => m.EquipmentItemId == id);
            if (tblEquipmentItem == null)
            {
                return NotFound();
            }

            _context.TblEquipmentItem.Remove(tblEquipmentItem);
            await _context.SaveChangesAsync();

            return Ok(tblEquipmentItem);
        }

        private bool TblEquipmentItemExists(Guid id)
        {
            return _context.TblEquipmentItem.Any(e => e.EquipmentItemId == id);
        }
    }
}