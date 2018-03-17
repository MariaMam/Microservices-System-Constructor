using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentMaintenanceLinkedEntity
    {
        public Guid EquipmentMaintenanceLinkedEntityId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid LinkedEntityId { get; set; }
        public Guid EquipmentMaintenanceId { get; set; }

        public TblEquipmentMaintenance EquipmentMaintenance { get; set; }
    }
}
