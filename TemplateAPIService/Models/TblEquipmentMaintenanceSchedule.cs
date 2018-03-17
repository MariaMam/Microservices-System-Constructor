using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentMaintenanceSchedule
    {
        public TblEquipmentMaintenanceSchedule()
        {
            TblEquipmentMaintenance = new HashSet<TblEquipmentMaintenance>();
            TblEquipmentMaintenanceScheduleLinkedEntity = new HashSet<TblEquipmentMaintenanceScheduleLinkedEntity>();
        }

        public Guid EquipmentMaintenanceScheduleId { get; set; }
        public Guid EquipmentMaintenanceGroupId { get; set; }
        public Guid? EquipmentItemId { get; set; }
        public Guid ScheduleType { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int MonthsEvery { get; set; }
        public Guid MaintenanceType { get; set; }
        public Guid AssignedBy { get; set; }
        public Guid AssignedTo { get; set; }
        public Guid? MaintenanceCompany { get; set; }
        public string Description { get; set; }
        public bool IsEmailToAssignedTo { get; set; }
        public bool IsEmailToCompany { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }
        public bool IsEnded { get; set; }
        public bool IsGroupSchedule { get; set; }
        public Guid? ParentEquipmentMaintenanceScheduleId { get; set; }

        public TblEquipmentItem EquipmentItem { get; set; }
        public TblEquipmentMaintenanceGroup EquipmentMaintenanceGroup { get; set; }
        public ICollection<TblEquipmentMaintenance> TblEquipmentMaintenance { get; set; }
        public ICollection<TblEquipmentMaintenanceScheduleLinkedEntity> TblEquipmentMaintenanceScheduleLinkedEntity { get; set; }
    }
}
