using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblLocationLevel
    {
        public TblLocationLevel()
        {
            TblLocation = new HashSet<TblLocation>();
        }

        public Guid LocationLevelId { get; set; }
        public string Name { get; set; }
        public int LocationLevelNumber { get; set; }

        public ICollection<TblLocation> TblLocation { get; set; }
    }
}
