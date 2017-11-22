using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleRule
    {
        public TblModuleRule()
        {
            TblModuleRuleMatrix = new HashSet<TblModuleRuleMatrix>();
        }

        public Guid ModuleRuleId { get; set; }
        public Guid ModuleId { get; set; }
        public string Name { get; set; }
        public bool IsHidden { get; set; }

        public TblEmexModule Module { get; set; }
        public ICollection<TblModuleRuleMatrix> TblModuleRuleMatrix { get; set; }
    }
}
