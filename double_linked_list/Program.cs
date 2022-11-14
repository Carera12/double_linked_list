using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class represent the node of doubly linked list.
         * It consist of the information part and links to
         * its succeeding and preceeding
         * in the of next and previous */
        public int noMhs;
        public String name;
        //point to the succedung node
        public Node next;
        //point to the precceeding node
        public Node prev;

    }
    class DoubleLinkedList
    {
        Node START;

        //constructor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the students: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDupiclate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
