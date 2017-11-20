using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentLocationLinkedEntity
    {
        public Guid EquipmentLocationLinkedEntityId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid LinkedEntityId { get; set; }
        public Guid EquipmentLocationId { get; set; }

        public TblEquipmentLocation EquipmentLocation { get; set; }
    }
}
