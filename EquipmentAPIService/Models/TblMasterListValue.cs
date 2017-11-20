using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblMasterListValue
    {
        public TblMasterListValue()
        {
            InverseParentValue = new HashSet<TblMasterListValue>();
        }

        public Guid ValueId { get; set; }
        public int MasterListId { get; set; }
        public string Title { get; set; }
        public Guid? ParentValueId { get; set; }
        public int Version { get; set; }
        public Guid? VersionParentId { get; set; }
        public byte AccessPermission { get; set; }
        public bool IsHidden { get; set; }
        public string Description { get; set; }
        public int? OrderId { get; set; }
        public bool? IsDefault { get; set; }
        public string Code { get; set; }

        public TblMasterListValue ParentValue { get; set; }
        public ICollection<TblMasterListValue> InverseParentValue { get; set; }
    }
}
