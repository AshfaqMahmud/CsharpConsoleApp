using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    internal class StaticCtor
    {
        static StaticCtor()
        {
            Console.WriteLine("Static constructor called");
        }

        public StaticCtor()
        {
            Console.WriteLine("Instance constructor called");
        }
    }
}
