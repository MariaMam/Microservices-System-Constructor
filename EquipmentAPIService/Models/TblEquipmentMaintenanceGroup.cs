using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentMaintenanceGroup
    {
        public TblEquipmentMaintenanceGroup()
        {
            TblEquipmentMaintenance = new HashSet<TblEquipmentMaintenance>();
            TblEquipmentMaintenanceSchedule = new HashSet<TblEquipmentMaintenanceSchedule>();
        }

        public Guid EquipmentMaintenanceGroupId { get; set; }

        public ICollection<TblEquipmentMaintenance> TblEquipmentMaintenance { get; set; }
        public ICollection<TblEquipmentMaintenanceSchedule> TblEquipmentMaintenanceSchedule { get; set; }
    }
}
