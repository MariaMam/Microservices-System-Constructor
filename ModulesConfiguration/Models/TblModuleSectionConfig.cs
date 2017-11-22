using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleSectionConfig
    {
        public TblModuleSectionConfig()
        {
            TblModuleControlConfig = new HashSet<TblModuleControlConfig>();
        }

        public Guid ModuleSectionConfigId { get; set; }
        public short DisplayOrder { get; set; }
        public bool IsDisabled { get; set; }
        public string Name { get; set; }

        public ICollection<TblModuleControlConfig> TblModuleControlConfig { get; set; }
    }
}
