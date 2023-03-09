using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndExceptionHandingDemo
{
    public class GenericDelegates
    {
        public delegate double AddNumber1Delegate(int no1, float no2, double no3); //Func
        public delegate void AddNumber2Delegate(int no1, float no2, double no3); //Action
        public delegate bool CheckLengthDelegate(string name); //Predicate
     
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
