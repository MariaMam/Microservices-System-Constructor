using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentMaintenanceScheduleLinkedEntity
    {
        public Guid EquipmentMaintenanceScheduleLinkedEntityId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid LinkedEntityId { get; set; }
        public Guid EquipmentMaintenanceScheduleId { get; set; }

        public TblEquipmentMaintenanceSchedule EquipmentMaintenanceSchedule { get; set; }
    }
}
