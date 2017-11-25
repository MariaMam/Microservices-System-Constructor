using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblMasterListValue
    {
        public TblMasterListValue()
        {
            InverseParentValue = new HashSet<TblMasterListValue>();
            TblGroupIso14001Navigation = new HashSet<TblGroup>();
            TblGroupIso2Navigation = new HashSet<TblGroup>();
            TblGroupIso9001Navigation = new HashSet<TblGroup>();
            TblGroupLocaleNavigation = new HashSet<TblGroup>();
            TblGroupLocationNavigation = new HashSet<TblGroup>();
            TblGroupOhsas18001Navigation = new HashSet<TblGroup>();
            TblGroupPlantSubType = new HashSet<TblGroup>();
            TblGroupUnitType = new HashSet<TblGroup>();
            TblGroupWorkGroupStatusNavigation = new HashSet<TblGroup>();
            TblLocationAddressAddressTypeNavigation = new HashSet<TblLocationAddress>();
            TblLocationAddressCityNavigation = new HashSet<TblLocationAddress>();
            TblLocationAddressCountryNavigation = new HashSet<TblLocationAddress>();
            TblLocationAddressCountyNavigation = new HashSet<TblLocationAddress>();
            TblMasterListValueMatrix = new HashSet<TblMasterListValueMatrix>();
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
        public ICollection<TblGroup> TblGroupIso14001Navigation { get; set; }
        public ICollection<TblGroup> TblGroupIso2Navigation { get; set; }
        public ICollection<TblGroup> TblGroupIso9001Navigation { get; set; }
        public ICollection<TblGroup> TblGroupLocaleNavigation { get; set; }
        public ICollection<TblGroup> TblGroupLocationNavigation { get; set; }
        public ICollection<TblGroup> TblGroupOhsas18001Navigation { get; set; }
        public ICollection<TblGroup> TblGroupPlantSubType { get; set; }
        public ICollection<TblGroup> TblGroupUnitType { get; set; }
        public ICollection<TblGroup> TblGroupWorkGroupStatusNavigation { get; set; }
        public ICollection<TblLocationAddress> TblLocationAddressAddressTypeNavigation { get; set; }
        public ICollection<TblLocationAddress> TblLocationAddressCityNavigation { get; set; }
        public ICollection<TblLocationAddress> TblLocationAddressCountryNavigation { get; set; }
        public ICollection<TblLocationAddress> TblLocationAddressCountyNavigation { get; set; }
        public ICollection<TblMasterListValueMatrix> TblMasterListValueMatrix { get; set; }
    }
}
