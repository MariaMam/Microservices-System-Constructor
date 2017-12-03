using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleControlConfigSetting
    {
        public Guid ModuleControlConfigSettingId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid? ModuleControlConfigId { get; set; }
        public string ColumnName { get; set; }
        public int DataType { get; set; }
        public bool IsConfigured { get; set; }
    }
}
