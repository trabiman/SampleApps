using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Logger;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogService logService = new FileLogService(typeof(Program));
            HelloWorldServiceClient client = new HelloWorldServiceClient();

            logService.Info("Preparing to call the Hello World Service");
            Console.WriteLine(client.GetMessage("Console Client App"));
            logService.Info("Hello World Service has returned");
            Console.WriteLine("Log has been written");
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
