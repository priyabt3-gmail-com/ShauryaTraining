using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day5
{
    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            //double linked list
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(90);
            l1.AddLast(67);
            l1.AddFirst(88);
            //88,90,67
            LinkedListNode<int> addr = l1.Find(90);
            l1.AddAfter(addr, 100);
            foreach(int d in l1)
                Console.WriteLine(d);
        }
    }
}
