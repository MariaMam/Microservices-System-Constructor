using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentLocation
    {
        public TblEquipmentLocation()
        {
            TblEquipmentLocationLinkedEntity = new HashSet<TblEquipmentLocationLinkedEntity>();
        }

        public Guid EquipmentLocationId { get; set; }
        public Guid EquipmentItemId { get; set; }
        public Guid LocationId { get; set; }
        public DateTime DateOn { get; set; }
        public DateTime? DateOff { get; set; }
        public Guid Status { get; set; }
        public string Notes { get; set; }
        public Guid? GroupId { get; set; }
        public Guid AssignedToId { get; set; }

        public TblEquipmentItem EquipmentItem { get; set; }
        public ICollection<TblEquipmentLocationLinkedEntity> TblEquipmentLocationLinkedEntity { get; set; }
    }
}
