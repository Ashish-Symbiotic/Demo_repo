using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_di_1
{
    class InjectorClass
    {
        private IBase ibase;
        public InjectorClass(IBase _ibase)
        {
            this.ibase = _ibase;
            ibase.printit();
        }
    }
}
