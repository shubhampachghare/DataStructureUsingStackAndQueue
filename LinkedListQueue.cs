using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUsingStackAndQueue
{
    public  class LinkedListQueue
    {
        Node head;
        public LinkedListQueue()
        {
            this.head = null;
        }

        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {

                head = node;
            }
            else
            {

                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                // this.head = temp;
                
                

            }
        }

        public void DeQueue()
        {

            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine(this.head.data + "is removed from Queue");
                this.head = this.head.next;
            }
        }
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Node temp = head;

                while (temp != null && temp.data != null)
                {
                    Console.WriteLine("Inserted into the Queue Successfully = " + temp.data);
                    temp = temp.next;

                }
            }
        }
    }
}
