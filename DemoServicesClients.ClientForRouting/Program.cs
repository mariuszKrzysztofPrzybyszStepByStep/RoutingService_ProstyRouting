namespace DemoServicesClients.ClientForRouting
{
    using System;
    using System.ServiceModel;
    using DemoServices.ServiceContracts;

    public class Program
    {
        private static void Main(string[] args) => CallEcho();

        private static void CallEcho()
        {
            Uri baseAddr = new Uri("http://localhost:7000/DemoServices/SimpleEchoService");
            string message = "Routing demo message";

            Console.WriteLine("Press [ENTER] to call SimpleEchoService");
            Console.ReadLine();

            using (ChannelFactory<IEchoService> factory = new ChannelFactory<IEchoService>(new BasicHttpBinding(),
                new EndpointAddress(baseAddr)))
            {
                try
                {
                    IEchoService proxy = factory.CreateChannel();
                    Console.WriteLine($"Service response: {proxy.GetData(message)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }

                Console.WriteLine("Press [ENTER] to close client");
                Console.ReadLine();
            }
        }
    }
}