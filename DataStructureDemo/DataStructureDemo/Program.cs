using DataStructureDemo;
using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.AddAll(23, 56, 78, 34, 56);
            list.InsertAtParticularPosition(2,30);
            list.Search(30);
            list.Display();
            Console.ReadKey();
        }
    }
}
