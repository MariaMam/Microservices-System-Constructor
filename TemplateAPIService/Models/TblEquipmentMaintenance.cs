using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentMaintenance
    {
        public TblEquipmentMaintenance()
        {
            TblEquipmentMaintenanceLinkedEntity = new HashSet<TblEquipmentMaintenanceLinkedEntity>();
        }

        public Guid EquipmentMaintenanceId { get; set; }
        public Guid EquipmentMaintenanceGroupId { get; set; }
        public Guid? EquipmentItemId { get; set; }
        public Guid MaintenanceType { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Mileage { get; set; }
        public int? UseHours { get; set; }
        public Guid AssignedBy { get; set; }
        public Guid AssignedTo { get; set; }
        public Guid? MaintenanceCompany { get; set; }
        public string Description { get; set; }
        public Guid Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid? EquipmentCategoryId { get; set; }
        public string EquipmentCategoryName { get; set; }
        public Guid? EquipmentItemTypeId { get; set; }
        public string EquipmentItemTypeName { get; set; }
        public Guid? EquipmentItemSubTypeId { get; set; }
        public string EquipmentItemLocationName { get; set; }
        public string DescriptionAfter { get; set; }
        public Guid? EquipmentMaintenanceScheduleId { get; set; }
        public string EquipmentItemSubTypeName { get; set; }
        public string ScheduleType { get; set; }
        public Guid? EquipmentItemLocationId { get; set; }

        public TblEquipmentItem EquipmentItem { get; set; }
        public TblEquipmentMaintenanceGroup EquipmentMaintenanceGroup { get; set; }
        public TblEquipmentMaintenanceSchedule EquipmentMaintenanceSchedule { get; set; }
        public ICollection<TblEquipmentMaintenanceLinkedEntity> TblEquipmentMaintenanceLinkedEntity { get; set; }
    }
}
