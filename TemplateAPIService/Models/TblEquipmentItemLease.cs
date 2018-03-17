using System;
using System.Collections.Generic;

namespace EquipmentAPIService.Models
{
    public partial class TblEquipmentItemLease
    {
        public Guid EquipmentItemLeaseId { get; set; }
        public Guid EquipmentItemId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? Cost { get; set; }
        public Guid? LeaseCompanyId { get; set; }
        public Guid? LeasePersonId { get; set; }
        public string Notes { get; set; }
        public DateTime? ReplacementDate { get; set; }
        public string ReplacementTerm { get; set; }
        public decimal? PeriodManagementFee { get; set; }
        public decimal? PeriodFixedCharge { get; set; }

        public TblEquipmentItem EquipmentItem { get; set; }
    }
}
