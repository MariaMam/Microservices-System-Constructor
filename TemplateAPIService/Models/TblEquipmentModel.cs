using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentModel
    {
        public TblEquipmentModel()
        {
            TblEquipmentConfig = new HashSet<TblEquipmentConfig>();
            TblEquipmentConfigControl = new HashSet<TblEquipmentConfigControl>();
            TblEquipmentModelConfig = new HashSet<TblEquipmentModelConfig>();
        }

        public Guid EquipmentModelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsHidden { get; set; }

        public ICollection<TblEquipmentConfig> TblEquipmentConfig { get; set; }
        public ICollection<TblEquipmentConfigControl> TblEquipmentConfigControl { get; set; }
        public ICollection<TblEquipmentModelConfig> TblEquipmentModelConfig { get; set; }
    }
}
