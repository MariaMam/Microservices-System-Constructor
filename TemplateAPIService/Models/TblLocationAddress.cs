using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblLocationAddress
    {
        public Guid AddressId { get; set; }
        public Guid LocationId { get; set; }
        public Guid AddressType { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public Guid Country { get; set; }
        public Guid County { get; set; }
        public Guid? City { get; set; }

        public TblMasterListValue AddressTypeNavigation { get; set; }
        public TblMasterListValue CityNavigation { get; set; }
        public TblMasterListValue CountryNavigation { get; set; }
        public TblMasterListValue CountyNavigation { get; set; }
        public TblLocation Location { get; set; }
    }
}
