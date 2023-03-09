using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndExceptionHandingDemo
{
    public delegate void Notify();  // delegate

    public class EventInDelegate
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
             OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }

    }
}