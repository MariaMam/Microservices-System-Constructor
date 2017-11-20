using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentAPIService.Models
{
    public interface IEquipmentRepository
    {
        void Add(TblEquipmentItem item);
        IEnumerable<TblEquipmentItem> GetAll();
        TblEquipmentItem FindByID(Guid key);
        TblEquipmentItem Remove(Guid key);
        void Update(TblEquipmentItem item);
    }
}
