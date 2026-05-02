using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
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
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
        }
        public bool Checkcircular()
        {
            ClassNode slow = head , fast = head;
            while (fast!=null &&  fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
