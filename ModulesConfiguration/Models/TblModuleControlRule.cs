using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleControlRule
    {
        public Guid ModuleControlRuleId { get; set; }
        public Guid ModuleControlConfigId { get; set; }
        public string Name { get; set; }

        public TblModuleControlConfig ModuleControlConfig { get; set; }
    }
}
