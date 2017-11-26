using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway.Models.Configuration
{
  public class ControlConfiguration
  {
    public Guid ModuleControlConfigId { get; set; }
    public Guid ModuleGroupConfigId { get; set; }
    public Guid? ModuleSectionConfigId { get; set; }
    public string ColumnName { get; set; }
    public int DataType { get; set; }
    public int DisplayOrder { get; set; }
    public bool IsDisabled { get; set; }
    public string DataUri { get; set; }
    public string Value { get; set; }
    public bool IsRequired { get; set; }
    public bool IsReadonly { get; set; }
    public bool IsCustomField { get; set; }
    public bool IsCustomControl { get; set; }
    public string Properties { get; set; }
    public bool Ignore { get; set; }
    public int? Width { get; set; }
    public int? Rows { get; set; }
  }
}
