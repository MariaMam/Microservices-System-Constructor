using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentItem
    {
        public TblEquipmentItem()
        {
            TblEquipmentItemLease = new HashSet<TblEquipmentItemLease>();
            TblEquipmentItemLinkedEntity = new HashSet<TblEquipmentItemLinkedEntity>();
            TblEquipmentLocation = new HashSet<TblEquipmentLocation>();
            TblEquipmentMaintenance = new HashSet<TblEquipmentMaintenance>();
            TblEquipmentMaintenanceSchedule = new HashSet<TblEquipmentMaintenanceSchedule>();
        }

        public Guid EquipmentItemId { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string AssetNumber { get; set; }
        public Guid Status { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? DisposalDate { get; set; }
        public Guid? DisposalMethod { get; set; }
        public decimal? DisposalCost { get; set; }
        public decimal? DisposalMileage { get; set; }
        public bool IsHidden { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? TaxExpiryDate { get; set; }
        public bool IsOnHire { get; set; }
        public decimal? MaintenanceBudget { get; set; }
        public Guid? DetailedCategory { get; set; }
        public string RegistrationNumber { get; set; }
        public string FleetNumber { get; set; }
        public string OperatorsLicense { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string EngineSize { get; set; }
        public decimal? Co2Output { get; set; }
        public string Colour { get; set; }
        public string ChasisNumber { get; set; }
        public string KeyNumber { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? PlatingDate { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? StartDistance { get; set; }
        public Guid? AcqusitionMethod { get; set; }
        public decimal? BenefitValue { get; set; }
        public decimal? LatestDistance { get; set; }
        public DateTime? LatestDistanceDate { get; set; }
        public string SpeedoAdjustment { get; set; }
        public DateTime? LicensedExpiryDate { get; set; }
        public decimal? LicenseBudget { get; set; }
        public Guid? Department { get; set; }
        public Guid? FuelType { get; set; }
        public Guid? TransmissionType { get; set; }
        public Guid? ClockType { get; set; }
        public string Quantity { get; set; }
        public string Condition { get; set; }
        public string ManufactureYear { get; set; }
        public DateTime? CertificateExpiryDate { get; set; }
        public Guid? EquipmentItemGroupId { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid? TypeId { get; set; }
        public string TypeName { get; set; }
        public Guid? SubTypeId { get; set; }
        public string SubTypeName { get; set; }
        public string LocationName { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? BusinessUnitHierarchyId { get; set; }
        public Guid? OwnerPerson { get; set; }
        public Guid? OwnerCompany { get; set; }
        public DateTime? ReplacementDate { get; set; }
        public int? ReplacementTerm { get; set; }
        public Guid? ReplacementTermType { get; set; }
        public string FinanceBudget { get; set; }
        public Guid? RoadLicenseType { get; set; }
        public DateTime? ServiceDateLast { get; set; }
        public DateTime? ServiceDateNext { get; set; }
        public string AssetHolder { get; set; }
        public Guid? ErpBusinessDivisionId { get; set; }
        public Guid? DestIndexId { get; set; }
        public Guid? GaapcodeId { get; set; }
        public Guid? ForestDistrictId { get; set; }
        public Guid? ForestUsageMethodId { get; set; }
        public string AddressName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouse { get; set; }
        public string AddressPostalIndex { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressAreal { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressArealText { get; set; }
        public string AddressDistrictText { get; set; }
        public Guid? LocationId { get; set; }

        public ICollection<TblEquipmentItemLease> TblEquipmentItemLease { get; set; }
        public ICollection<TblEquipmentItemLinkedEntity> TblEquipmentItemLinkedEntity { get; set; }
        public ICollection<TblEquipmentLocation> TblEquipmentLocation { get; set; }
        public ICollection<TblEquipmentMaintenance> TblEquipmentMaintenance { get; set; }
        public ICollection<TblEquipmentMaintenanceSchedule> TblEquipmentMaintenanceSchedule { get; set; }
    }
}
