using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentConfigControlProperty
    {
        public Guid EquipmentConfigControlPropertyId { get; set; }
        public Guid EquipmentConfigControlId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public string PropertyType { get; set; }

        public TblEquipmentConfigControl EquipmentConfigControl { get; set; }
    }
}
