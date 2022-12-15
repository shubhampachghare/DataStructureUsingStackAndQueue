using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructureUsingStackAndQueue
{
    class LinkedListStack
    {
        public Node top;

        public LinkedListStack()
        {
            this.top = null;
        }

        
        public void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }

       
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Inserted into the stack Successfully = " + temp.data);
                temp = temp.next;
            }
        }
    }
}

