using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ServiceB : IServiceB
    {
        private readonly IServiceC _serviceC;
        public ServiceB(IServiceC serviceC)
        {
            _serviceC = serviceC;
        }

        public void DoSomethingB()
        {
            Console.WriteLine(_serviceC.DoSomething());
        }
    }
}
