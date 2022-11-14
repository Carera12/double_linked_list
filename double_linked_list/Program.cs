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
        public int name;
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
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
