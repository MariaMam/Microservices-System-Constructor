using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblLocation
    {
        public TblLocation()
        {
            InverseParentLocation = new HashSet<TblLocation>();
            TblLocationAddress = new HashSet<TblLocationAddress>();
            TblLocationMatrix = new HashSet<TblLocationMatrix>();
        }

        public Guid LocationId { get; set; }
        public string Name { get; set; }
        public Guid? ParentLocationId { get; set; }
        public Guid? LocationLevelId { get; set; }
        public bool IsHidden { get; set; }
        public string LocationPath { get; set; }

        public TblLocationLevel LocationLevel { get; set; }
        public TblLocation ParentLocation { get; set; }
        public ICollection<TblLocation> InverseParentLocation { get; set; }
        public ICollection<TblLocationAddress> TblLocationAddress { get; set; }
        public ICollection<TblLocationMatrix> TblLocationMatrix { get; set; }
    }
}
