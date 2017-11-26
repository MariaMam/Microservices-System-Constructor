using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway
{
  public class ParseColumnName
  {
    string table;
    string column;
    public ParseColumnName(string columnName)
    {
      var array = columnName.Split('.');
      this.table = array[0];
      this.column = array[1];

    }

  }
}
