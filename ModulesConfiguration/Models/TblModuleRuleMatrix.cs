using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleRuleMatrix
    {
        public Guid MatrixId { get; set; }
        public Guid ModuleRuleId { get; set; }
        public int RoleId { get; set; }

        public TblModuleRule ModuleRule { get; set; }
    }
}
