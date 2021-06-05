using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ServiceA : IServiceA
    {
        private readonly IServiceB _serviceB;
        public ServiceA(IServiceB serviceB)
        {
            _serviceB = serviceB;
        }

        public void dosomethinga()
        {
            _serviceB.DoSomethingB();
            Console.WriteLine("dadadadaa a a a a");
        }
    }
}
