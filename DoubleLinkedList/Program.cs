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
        public void addNode()/*Adds a new node*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student : ");
            rollNo = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            /*Checks if the list is empty*/
            if (START == null || rollNo <= START.rollNumber)
            {
                if((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;

            }
            node previous, current;
            for(current = previous = START; current !=null &&
                rollNo >= current.rollNumber; previous = current, current = current.next)
            {
                if(rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
            /*On the execution of the above of the above for loop, prev and
             *current will point to those nodes
             between which the new node is to be inserted.*/
            newnode.next = current;
            newnode.prev = previous;

            /*If the node is to be inserted at the end of the list*/
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;
            }
            current.prev = newnode;
            previous.next = newnode;
        }

        /*Checks whether the specified node is present*/
        public bool Search(int rollNo, ref node previous, ref node current)
        {
            for (previous = current = START;
                current != null && rollNo != current.rollNumber;
                previous = current, current = current.next)
            { }
            /*The above for loop traverses the list. If the specified node
             is found then the function returns true, otherwise false.*/
            return (current != null);
        }
        static void Main(string[] args)
        {
        }
    }

}
