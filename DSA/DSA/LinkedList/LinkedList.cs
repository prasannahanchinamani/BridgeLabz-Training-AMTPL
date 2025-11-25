using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            this.next = null;
        }
    }
        public class LinkedListExample
        {
            public Node head;
            public void AddLast(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }

            }
            public void Display()
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.Write(temp.data);
        }
            public void DeleteFirstElement()
            {
                if ((head == null))
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                else
                {
                    head = head.next;
                }

            }
            public void AddFirst(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.next = head;
                     head = newNode;
                }
            }
            public void DeleteLastElement()
            {
                if (head == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                else if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;

                }
            }
            public static void Main(string[] args)
            {
                LinkedListExample linkedList = new LinkedListExample();
                linkedList.AddLast(10);
                linkedList.AddLast(20);
                linkedList.AddLast(30);
                linkedList.Display();
                Console.WriteLine();
                linkedList.DeleteFirstElement();
                linkedList.Display();
                Console.WriteLine();
                linkedList.AddFirst(5);
                linkedList.Display();
                Console.WriteLine();
                linkedList.DeleteLastElement();
                linkedList.Display();
            }
        }
    }


