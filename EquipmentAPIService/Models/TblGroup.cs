using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblGroup
    {
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsConfig { get; set; }
        public string LogoPath { get; set; }
        public Guid? Locale { get; set; }
        public string Reference { get; set; }
        public Guid? WorkGroupStatus { get; set; }
        public bool? ReportStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EstabilishmentName { get; set; }
        public string Description { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? Premises { get; set; }
        public string Certifications { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public Guid? Location { get; set; }
        public bool IsRoot { get; set; }
        public bool AllowData { get; set; }
        public string GroupHierarchy { get; set; }
        public string ActivityCodeIds { get; set; }
        public string ActivityCodeTitles { get; set; }
        public string ShapeGeoData { get; set; }
        public string MapLevel1Code { get; set; }
        public string MapLevel2Subregion { get; set; }
        public string MapLevel3Region { get; set; }
        public string MapLevel4Country { get; set; }
        public int? HierarchyLevelNumber { get; set; }
        public string PointGeoData { get; set; }
        public bool IsReportingOnly { get; set; }
        public bool IsEnvironmentalReporting { get; set; }
        public string GroupLevel01 { get; set; }
        public string GroupLevel02 { get; set; }
        public string GroupLevel03 { get; set; }
        public string GroupLevel04 { get; set; }
        public string GroupLevel05 { get; set; }
        public string GroupLevel06 { get; set; }
        public string GroupLevel07 { get; set; }
        public string GroupLevel08 { get; set; }
        public string GroupLevel09 { get; set; }
        public string GroupLevel10 { get; set; }
        public byte[] LogoData { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? Iso2 { get; set; }
        public Guid? Ohsas18001 { get; set; }
        public Guid? Iso14001 { get; set; }
        public Guid? Iso9001 { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string Code3 { get; set; }
        public Guid? UnitTypeId { get; set; }
        public Guid? PlantSubTypeId { get; set; }

        public TblMasterListValue Iso14001Navigation { get; set; }
        public TblMasterListValue Iso2Navigation { get; set; }
        public TblMasterListValue Iso9001Navigation { get; set; }
        public TblMasterListValue LocaleNavigation { get; set; }
        public TblMasterListValue LocationNavigation { get; set; }
        public TblMasterListValue Ohsas18001Navigation { get; set; }
        public TblMasterListValue PlantSubType { get; set; }
        public TblMasterListValue UnitType { get; set; }
        public TblMasterListValue WorkGroupStatusNavigation { get; set; }
    }
}
