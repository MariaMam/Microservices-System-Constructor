using System;
using System.Collections.Generic;

namespace ModuleConfiguration.Models
{
    public partial class TblEmexModule
    {
        public TblEmexModule()
        {
            TblModuleConfig = new HashSet<TblModuleConfig>();
            TblModuleRule = new HashSet<TblModuleRule>();
        }

        public Guid ModuleId { get; set; }
        public string Name { get; set; }
        public string DocumentEntityTypes { get; set; }
        public bool IsActive { get; set; }
        public bool? IsUsedInSearchGroups { get; set; }
        public bool? IsUsedInReports { get; set; }
        public bool? IsUsedInDocuments { get; set; }
        public bool IsConfigurable { get; set; }

        public ICollection<TblModuleConfig> TblModuleConfig { get; set; }
        public ICollection<TblModuleRule> TblModuleRule { get; set; }
    }
}
