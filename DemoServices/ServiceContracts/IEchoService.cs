using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DemoServices.ServiceContracts
{
    [ServiceContract(Namespace = "http://routingdemo.com/")]
    public interface IEchoService
    {
        [OperationContract]
        string GetData(string message);
    }
}