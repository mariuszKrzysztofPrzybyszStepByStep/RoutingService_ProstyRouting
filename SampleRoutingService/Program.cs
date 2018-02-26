using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Routing;
using System.Text;
using System.Threading.Tasks;

namespace SampleRoutingService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(RoutingService)))
            {
                try
                {
                    Console.WriteLine("RoutingService is starting");
                    host.Open();
                    foreach (ServiceEndpoint se in host.Description.Endpoints)
                    {
                        Console.WriteLine($"\nAddress: {se.Address}," +
                            $"\n\tBinding: {se.Binding.Name}, \n\tContract: {se.Contract.Name}");
                    }
                    Console.WriteLine("RoutingService started. Press [ENTER] to close");
                    Console.ReadLine();
                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}