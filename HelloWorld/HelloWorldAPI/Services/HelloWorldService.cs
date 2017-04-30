using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Services
{
    public class HelloWorldService : IHelloWorldService 
    {
        public string GetMessage(string name)
        {
            return "Hello World... sent from " + name + "!";
        } 
    }
}
