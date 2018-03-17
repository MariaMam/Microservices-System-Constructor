using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentItemLinkedEntity
    {
        public Guid EquipmentItemLinkedEntityId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid LinkedEntityId { get; set; }
        public Guid EquipmentItemId { get; set; }
        public Guid? LinkedType { get; set; }

        public TblEquipmentItem EquipmentItem { get; set; }
    }
}
