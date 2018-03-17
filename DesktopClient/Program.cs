using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      SetConnections();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

     
    }

    static void SetConnections()
    {

      var client = new MongoClient("mongodb://mariamamont:hse2330230@cluster0-t69yp.mongodb.net");
      //var client = new MongoClient("mongodb + srv://mariamamont:90UFj7b4psjKSJkF@cluster0-t69yp.mongodb.net/masterDB");
      var database = client.GetDatabase("masterDB");

    }

    static void GetConfiguration()
    {
      //var client = new MongoClient("mongodb://kay:myRealPassword@mycluster0-shard-00-00.mongodb.net:27017,mycluster0-shard-00-01.mongodb.net:27017,mycluster0-shard-00-02.mongodb.net:27017/admin?ssl=true&replicaSet=Mycluster0-shard-0&authSource=admin");
      //var database = client.GetDatabase("test");


    }


  }
}
