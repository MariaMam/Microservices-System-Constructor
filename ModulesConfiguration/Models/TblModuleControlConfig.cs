using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleControlConfig
    {
        public TblModuleControlConfig()
        {
            TblModuleControlRule = new HashSet<TblModuleControlRule>();
        }

        public Guid ModuleControlConfigId { get; set; }
        public Guid ModuleGroupConfigId { get; set; }
        public Guid? ModuleSectionConfigId { get; set; }
        public string ColumnName { get; set; }
        public int DataType { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDisabled { get; set; }
        public string DataUri { get; set; }
        public string Value { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsCustomField { get; set; }
        public bool IsCustomControl { get; set; }
        public string Properties { get; set; }
        public bool Ignore { get; set; }
        public int? Width { get; set; }
        public int? Rows { get; set; }

        public TblModuleGroupConfig ModuleGroupConfig { get; set; }
        public TblModuleSectionConfig ModuleSectionConfig { get; set; }
        public ICollection<TblModuleControlRule> TblModuleControlRule { get; set; }
    }
}
