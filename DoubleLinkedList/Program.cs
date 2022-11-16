using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class node
    {
        /*Node class represents the node of doubly linked list.
         *It consists of the information part and links to
         *Its succeeding and preceeding nodes
         In terms of nest and previous nodes.*/
        public int rollNumber;
        public string name;
        public node next;/*points to the succeeding node*/
        public node prev;/*points to the precceeding node*/

    }

    class DoubleLinkedList
    {
        node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        
        static void Main(string[] args)
        {
        }
    }

}
