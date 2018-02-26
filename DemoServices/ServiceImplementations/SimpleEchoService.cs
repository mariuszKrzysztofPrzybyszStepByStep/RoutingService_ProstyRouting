using DemoServices.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoServices.ServiceImplementations
{
    public class SimpleEchoService : IEchoService
    {
        public string GetData(string message)
        {
            Console.WriteLine($"SimpleEchoService: {message}");

            return message;
        }
    }
}