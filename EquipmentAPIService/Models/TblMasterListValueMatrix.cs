using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblMasterListValueMatrix
    {
        public Guid MasterListValueMatrixId { get; set; }
        public Guid RowId { get; set; }
        public int MasterListId { get; set; }
        public Guid MasterListValueId { get; set; }
        public bool IsPrimary { get; set; }

        public TblMasterListValue MasterListValue { get; set; }
    }
}
