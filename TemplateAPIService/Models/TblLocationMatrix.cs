using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblLocationMatrix
    {
        public Guid LocationMatrixId { get; set; }
        public Guid RowId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid LocationId { get; set; }
        public bool IsPrimary { get; set; }

        public TblLocation Location { get; set; }
    }
}
