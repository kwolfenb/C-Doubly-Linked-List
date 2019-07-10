using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    class Node
    {
        public int data;
        public Node prev;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.prev = null;
            this.next = null;
        }
    }
    class DoublyLinkedList
    {
        Node head;
        Node tail;
        int length;
        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.length = 0;
        }

        void Traverse()
        {
            if (this.length == 0)
            {
                Console.WriteLine("Empty List");
            }
            Node currentNode = this.head;
            int currentInt = 1;
            while (currentNode != null)
            {
                if (currentNode == this.head)
                {
                    Console.WriteLine("| Head (node " + currentInt + ") : " + currentNode.data);
                }
                if (currentNode == this.tail)
                {
                    Console.WriteLine("| Tail (node " + currentInt + ") : " + currentNode.data);
                }
                else if (currentNode != this.head && currentNode != this.tail)
                {
                    Console.WriteLine("| Node " + currentInt + ": " + currentNode.data);
                }
                currentInt++;
                if (currentNode.next == null)
                {
                    break;
                }
                currentNode = currentNode.next;
            }
        }
        void Push(int data) // add value to end of list
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail.next = newNode;
                newNode.prev = this.tail;
                this.tail = newNode;
            }
            this.length++;
        }
        Node Pop() // Remove from the end of list and return value
        {
            if (this.head == null)
            {
                return this.head; // returns null
            }
            Node prevTail = this.tail;
            if (this.length == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.tail = prevTail.prev;
                this.tail.next = null;
            }
            length--;
            prevTail.prev = null; //Set prev node to be null so the list can't be accessed from popped node
            return prevTail;
        }
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Console.WriteLine("New list with 1-4");
            list.Push(1); list.Push(2); list.Push(3); list.Push(4);
            list.Traverse();
            Node node = list.Pop(); Console.WriteLine("Pop " + node.data); list.Traverse();
        }

    }

}
