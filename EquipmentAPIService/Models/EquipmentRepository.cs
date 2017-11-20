using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipmentAPIService.Models
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private static ConcurrentDictionary<string, TblEquipmentItem> _equipments =
              new ConcurrentDictionary<string, TblEquipmentItem>();
        private readonly EquipmentDBContext _context;

        public EquipmentRepository(EquipmentDBContext context)
        {
            _context = context;
            Add(new TblEquipmentItem { Name = "Item1" });
        }

        public IEnumerable<TblEquipmentItem> GetAll()
        {
            return _context.TblEquipmentItem.OrderByDescending(u => u.AssetNumber).Take(20);
        }

        public void Add(TblEquipmentItem item)
        {
            item.EquipmentItemId = Guid.NewGuid();
            _equipments[item.EquipmentItemId.ToString()] = item;
        }

        public TblEquipmentItem FindByID(Guid id)
        {
            TblEquipmentItem item = _context.TblEquipmentItem.Find(id);
            return item;
        }

        public TblEquipmentItem Remove(Guid id)
        {
            TblEquipmentItem item = _context.TblEquipmentItem.Find(id);
            _context.Remove(item);
            return item;
        }

        public void Update(TblEquipmentItem item)
        {


        }
        //TODO - rework to Asynchronic
        /*
        public async Task<IActionResult> Update(Guid id, [Bind("ID,EnrollmentDate,FirstMidName,LastName")] TblEquipmentItem item)
        {
            
        }*/
    }
}
