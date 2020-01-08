using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_di_1
{
    class DerivedClass : BaseClass
    {
        public  void printit()
        {
            Console.WriteLine("We are Printing in Dervied Class");
        }
    }
}
