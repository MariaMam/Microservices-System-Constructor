using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblModuleGroupRuleFields
    {
        public Guid ModuleGroupRuleFieldId { get; set; }
        public Guid ModuleGroupRuleId { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }
        public int DataType { get; set; }

        public TblModuleGroupRule ModuleGroupRule { get; set; }
    }
}
