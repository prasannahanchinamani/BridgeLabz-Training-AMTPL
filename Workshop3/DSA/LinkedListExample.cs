using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Node<T>
    {
        public T Data { get; set; }       
        public Node<T> Next { get; set; } 

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

    }
    internal class LinkedListExample<T>
    {
         public Node<T> head;
        int size = 0;
         public void AddAtStarting(T data)
        {
            Node<T> newNode=new Node<T>(data);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
              newNode.Next = head;
               head = newNode;
                
            }
            size++;
           
        }
        public void AddAtend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            size++;
        }
        public void insertAtIndex(T data,int index)
        {
            Node<T> newNode= new Node<T>(data);
            Node<T> temp= head;
            Node<T> prev = null;
            if (index == 0)
            {
                newNode.Next= head;
                head = newNode;
                size++;
                return;
            }
            if (index>size)
            {
                throw new IndexOutOfRangeException();
            }
            while (temp!=null && index > 0)
            {
                prev = temp;
                temp = temp.Next;
                index--;
            }
            prev.Next = newNode;
            newNode.Next = temp;
            size++;
        }
        public void DeleteAtstarting()
        {
             
            if (size>1)
            {
                head=head.Next;
                size--;
            }
            else
            {
                Console.WriteLine("Not possible");
                head = null;
            }
            
        }
        public void DeleteAtEnd()
        {
            if (size == 1)
            {
                head =null;
                size--;
            }

            else
            {
                Node<T> temp = head;
                while (temp.Next.Next != null)
                {
                    temp= temp.Next;
                }
                temp.Next = null;
                size--;
            }
        }
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Not in range");

            Node<T> temp = head;
            Node<T> prev = null;

            if (index == 0)
            {
                head = head.Next;
                size--;
                return;
            }

            while (temp != null && index > 0)
            {
                prev = temp;
                temp = temp.Next;
                index--;
            }

            prev.Next = temp.Next;
            size--;
        }
        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> curr = head;
            Node<T> next = null;

            while (curr != null)
            {
                next = curr.Next;  
                curr.Next = prev;  
                prev = curr;        
                curr = next;       
            }

            head = prev;
        }
        public bool IsEmpty()
        {
                return size == 0;
        }
    }
}
