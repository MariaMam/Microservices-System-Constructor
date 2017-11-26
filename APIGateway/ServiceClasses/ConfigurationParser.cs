using APIGateway.Models.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace APIGateway
{
    public class ConfigurationParser
  {

    public ConfigurationParser() { }

    public static JArray ParseResponse(string configs) {

      var json = JArray.Parse(configs);
      return json;
    }

    public static JObject ParseResponseObject(string configs)
    {

      var json = JObject.Parse(configs);
      return json;
    }


  }
}

