using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class NodeList
    {
        private ClassNode head;
        public void Add(int value)
        {
            
            ClassNode NewNode = new ClassNode(value);
            if (head == null)
            {
                head = NewNode;
                return;
            }

            ClassNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = NewNode;
        }
        public void Display()
        {
            ClassNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.nodevalue+" ");
                temp = temp.next;
            }
        }
        public void DisplayMiddle()
        {          
            ClassNode temp = head;
            int n = 0;
            if (temp == null) return;
            while (temp != null)
            {
                n++;
                temp = temp.next;
            }
            
            int x = n/2;
            temp = head;
            while (x != 0)
            {
                temp = temp.next;
                x--;
            }
            Console.WriteLine(temp.nodevalue);
        }
    }
}
