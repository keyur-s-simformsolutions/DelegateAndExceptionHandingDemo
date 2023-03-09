using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndExceptionHandingDemo
{
    using System;

    delegate int MyDelegate(int x, int y);

    class SingleCast
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
    }

}
