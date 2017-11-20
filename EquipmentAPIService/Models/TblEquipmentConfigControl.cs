using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentConfigControl
    {
        public TblEquipmentConfigControl()
        {
            TblEquipmentConfigControlProperty = new HashSet<TblEquipmentConfigControlProperty>();
        }

        public Guid EquipmentConfigControlId { get; set; }
        public Guid EquipmentModelId { get; set; }
        public int OrderId { get; set; }
        public string ControlId { get; set; }
        public string ControlPath { get; set; }
        public bool? IsHidden { get; set; }
        public bool IsReportable { get; set; }

        public TblEquipmentModel EquipmentModel { get; set; }
        public ICollection<TblEquipmentConfigControlProperty> TblEquipmentConfigControlProperty { get; set; }
    }
}
