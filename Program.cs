using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_di_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            InjectorClass cs = new InjectorClass(new BaseClass());
            Console.ReadKey();

        }
    }
}
