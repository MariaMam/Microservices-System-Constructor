using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient
{
  class MockMemory
  {
    ArrayList microservices = new ArrayList();

    public MockMemory()
    {

      MicroserviceInfo m1 = new MicroserviceInfo("APIGateway", "API Gateway");
      MicroserviceInfo m2 = new MicroserviceInfo("Equipment Service", "Equipment Service");
      microservices.Add(m1);
      microservices.Add(m2);

    }

  }
}
