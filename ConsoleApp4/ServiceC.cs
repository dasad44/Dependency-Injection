using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ServiceC : IServiceC
    {
        public string DoSomething()
        {
            Console.WriteLine("dosomething");
            return "Dasdasdas";
        }
    }
}
