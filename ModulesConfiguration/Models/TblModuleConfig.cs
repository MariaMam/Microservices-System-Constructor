using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleConfig
    {
        public TblModuleConfig()
        {
            TblModuleGroupConfig = new HashSet<TblModuleGroupConfig>();
        }

        public Guid ModuleConfigId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid? ConfiguredBy { get; set; }
        public string Name { get; set; }

        public TblEmexModule Module { get; set; }
        public ICollection<TblModuleGroupConfig> TblModuleGroupConfig { get; set; }
    }
}
