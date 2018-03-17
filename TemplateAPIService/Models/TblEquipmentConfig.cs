using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentConfig
    {
        public Guid ConfigId { get; set; }
        public Guid? EquipmentModelId { get; set; }
        public string Code { get; set; }
        public string CodeValue { get; set; }
        public string CodeValue1 { get; set; }

        public TblEquipmentModel EquipmentModel { get; set; }
    }
}
