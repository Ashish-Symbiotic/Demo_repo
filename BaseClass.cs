using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_di_1
{

    class BaseClass :IBase
    {
        public  void printit()
        {
            Console.WriteLine("We Are Printing");
        }
    }
    public interface IBase
    {
         void printit();
    }
}
