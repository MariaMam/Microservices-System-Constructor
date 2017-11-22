using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleGroupConfig
    {
        public TblModuleGroupConfig()
        {
            TblModuleControlConfig = new HashSet<TblModuleControlConfig>();
            TblModuleGroupRule = new HashSet<TblModuleGroupRule>();
        }

        public Guid ModuleGroupConfigId { get; set; }
        public Guid ModuleConfigId { get; set; }
        public short DisplayOrder { get; set; }
        public bool IsDisabled { get; set; }
        public string Name { get; set; }

        public TblModuleConfig ModuleConfig { get; set; }
        public ICollection<TblModuleControlConfig> TblModuleControlConfig { get; set; }
        public ICollection<TblModuleGroupRule> TblModuleGroupRule { get; set; }
    }
}
