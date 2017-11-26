using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway.ServiceClasses
{
  public class Column
  {
    public String ColumnName { get; set; }
    public String TableName { get; set; }
    public Column(string columnName)
    {
      var array = columnName.Split(".");
      TableName = array[0];
      ColumnName = array[1];

    }
  }
}
