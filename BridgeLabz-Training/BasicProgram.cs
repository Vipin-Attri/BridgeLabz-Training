using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training
{
    internal class BasicProgram
    {
        public void BasicProgramFun() { 
        
            string name = "Vipin";

            Console.WriteLine(name);

            string ss = "";


            for(int i=name.Length-1; i>=0; i--)
            {
                ss = ss + name[i];
            }


            Console.WriteLine(ss);
        }
    }
}
