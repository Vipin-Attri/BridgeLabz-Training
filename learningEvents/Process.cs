using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningEvents
{
    public delegate void Notify();
    internal class Process
    {
        public event Notify OnCompleted;

        public void Start()
        {
            Console.WriteLine("Process Invoked");
            OnCompleted?.Invoke();
        }
    }
}
