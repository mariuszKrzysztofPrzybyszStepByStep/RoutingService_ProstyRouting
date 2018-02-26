namespace DemoServicesHosts.EchoForRouting
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using DemoServices.ServiceImplementations;

    internal class Program
    {
        private static void Main(string[] args) => SimpleRouting();

        private static void SimpleRouting()
        {
            Console.WriteLine("EchoForRouting Host starting");
            using (ServiceHost host = new ServiceHost(typeof(SimpleEchoService),
                new Uri("http://localhost:7000/DemoServices/SimpleEchoService")))
            {
                host.Open();
                foreach (ServiceEndpoint se in host.Description.Endpoints)
                {
                    Console.WriteLine($"\nAddress: {se.Address}," +
                        $"\n\tBinding: {se.Binding.Name}, \n\tContract: {se.Contract.Name}");
                }

                Console.WriteLine("EchoForRouting Host started. Press [ENTER] to close");
                Console.ReadLine();
            }
        }
    }
}