using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class ClassNode
    {
        public int nodevalue;
        public ClassNode next;
        public ClassNode(int Nodevalue) {
            nodevalue = Nodevalue;
            next = null;
        }
    }
}
