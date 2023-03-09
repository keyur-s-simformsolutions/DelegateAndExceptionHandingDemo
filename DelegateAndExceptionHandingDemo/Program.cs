using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndExceptionHandingDemo
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Select Delegates types and CallBack & Events :\n S. SingleCast Delegate \n M. MultiCast Delegate \n G. Generic Delegate \n C. CallBack \n E. Event \n");
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.S:
                        // SingleCast Delegate Examples

                        MyDelegate del = new MyDelegate(SingleCast.Add);
                        int result = del(10, 20);
                        Console.WriteLine("\n Result: " + result);
                        break;
                    case ConsoleKey.M:
                        //MultiCaste Example
                        MultiClass multiClass = new MultiClass();
                        CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;


                        hiDel = MultiClass.Hello;
                        byeDel = MultiClass.Goodbye;

                        multiDel = hiDel + byeDel;

                        multiMinusHiDel = multiDel - hiDel;

                        Console.WriteLine("\nInvoking delegate hiDel:");
                        hiDel("Keyur");
                        Console.WriteLine("Invoking delegate byeDel:");
                        byeDel("Manan");
                        Console.WriteLine("Invoking delegate multiDel:");
                        multiDel("Divya");
                        Console.WriteLine("Invoking delegate multiMinusHiDel:");
                        multiMinusHiDel("Mahesh");

                        break;

                    case ConsoleKey.G:
                        //Generic Delegate
                        GenericDelegates.AddNumber1Delegate obj1 = new GenericDelegates.AddNumber1Delegate(GenericDelegates.AddNumber1);
                        double Result = obj1.Invoke(100, 125.45f, 456.789);
                        Console.WriteLine(Result);
                        GenericDelegates.AddNumber2Delegate obj2 = new GenericDelegates.AddNumber2Delegate(GenericDelegates.AddNumber2);
                        obj2.Invoke(50, 255.45f, 123.456);
                        GenericDelegates.CheckLengthDelegate obj3 = new GenericDelegates.CheckLengthDelegate(GenericDelegates.CheckLength);
                        bool Status = obj3.Invoke("Keyur");
                        Console.WriteLine(Status);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        //CallBack in delegate
                        CallBack callBack = new CallBack();
                        callBack.Double(5, callBack.MyCallbackFunction);
                        break;
                    case ConsoleKey.E:
                        //Event In Delegate
                        EventInDelegate myObject = new EventInDelegate();
                        myObject.ProcessCompleted += EventInDelegate.bl_ProcessCompleted;
                        myObject.StartProcess();
                        break;  
                }
            } while(key.Key!=ConsoleKey.X);
            Console.ReadKey();
                       
        }
    }
}
