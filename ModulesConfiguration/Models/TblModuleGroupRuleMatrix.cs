using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleGroupRuleMatrix
    {
        public Guid MatrixId { get; set; }
        public Guid ModuleGroupRuleId { get; set; }
        public int RoleId { get; set; }

        public TblModuleGroupRule ModuleGroupRule { get; set; }
    }
}
