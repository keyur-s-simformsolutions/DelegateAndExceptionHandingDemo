using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndExceptionHandingDemo
{
    internal class CallBack
    {
        public delegate void MyCallback(int result);
        public void Double(int x, MyCallback callback)
        {
            int result = x * 2;
            callback(result);
        }
        public void MyCallbackFunction(int result)
        {
            Console.WriteLine("Result is: " + result);
        }

    }
}
