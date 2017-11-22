using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleGroupRule
    {
        public TblModuleGroupRule()
        {
            TblModuleGroupRuleFields = new HashSet<TblModuleGroupRuleFields>();
            TblModuleGroupRuleMatrix = new HashSet<TblModuleGroupRuleMatrix>();
        }

        public Guid ModuleGroupRuleId { get; set; }
        public Guid ModuleGroupConfigId { get; set; }
        public bool? IsHidden { get; set; }
        public bool? IsReadonly { get; set; }

        public TblModuleGroupConfig ModuleGroupConfig { get; set; }
        public ICollection<TblModuleGroupRuleFields> TblModuleGroupRuleFields { get; set; }
        public ICollection<TblModuleGroupRuleMatrix> TblModuleGroupRuleMatrix { get; set; }
    }
}
