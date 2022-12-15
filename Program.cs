using System;

namespace DataStructureUsingStackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome datastructure using stack and queue");
            /*LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();*/

            /*LinkedListStack linkedListStack1 = new LinkedListStack();
            linkedListStack1.push(70);
            linkedListStack1.push(30);
            linkedListStack1.push(56);
            linkedListStack1.Display();
            linkedListStack1.peek();
            linkedListStack1.Display();
            linkedListStack1.pop();
            linkedListStack1.Display();
            linkedListStack1.isEmpty();
            linkedListStack1.Display();
            

            LinkedListQueue queue = new LinkedListQueue();
            queue.EnQueue(56);
            queue.EnQueue(30);
            queue.EnQueue(70);
            queue.display();
            */

            LinkedListQueue queue1 = new LinkedListQueue();
            queue1.EnQueue(56);
            queue1.EnQueue(30);
            queue1.EnQueue(70);
            queue1.display();

            queue1.DeQueue();
            queue1.display();
            Console.ReadKey();
        }
    }
}