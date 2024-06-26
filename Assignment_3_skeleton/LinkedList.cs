﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
    public class LinkedList : ILinkedListADT
    {
        public Node head;
        public int listSize;

        // SLL class constructor 
        // Create empty list
        public LinkedList()
        {
            head = null;
            listSize = 0;
        }

        //Return the boolean if the list is empty or not
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            head = null;
            listSize = 0;
        }

        //adds node to the end of the list
        public void Append(Object data)
        {
            Node newNode = new Node(data);
            listSize++;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //adds node to the beginning of the list
        public void Prepend(object data) 
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            listSize++;
        }
        //inserts node in to chosen index
        public void Insert(Object data, int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException();
            }
            Node newNode = new Node(data);
           Node currentNode = head;
            int listCount = 0;
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
                listSize++;
                return;
            }
            while (listCount < index)
            {
                if(currentNode == null)
                {
                    throw new IndexOutOfRangeException();
                }
                currentNode= currentNode.Next;
                listCount++;
            }

            newNode.Next = currentNode;
        }
        // replaces node at index
        public void Replace(Object data, int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException();
            }
            int listCount = 0;
            Node newNode = new Node(data);
           Node currentNode = head.Next;
            Node previousNode = head;
            while (currentNode != null)
            {
                if(index == listCount) 
                { 
                    break; 
                }
                previousNode = currentNode;
                currentNode= currentNode.Next;
                
                listCount++;
            }
            newNode.Next = currentNode.Next;
            previousNode.Next = currentNode;
            currentNode.Next = null;
        }


        // Return the size of the SLL
        public int Size()
        {
            if (head is null)
            {
                return 0;
            }
            return listSize;
        }

        // Remove node at certain index from SLL
        // index => the index opf the node to be removed
        public void Delete(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }

            if (index == 0)
            {
                listSize--;
                RemoveFirst();
                return;
            }

            Node currentNode = head;
            Node previousNode = null;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            previousNode.Next = currentNode.Next;
            listSize--;
        }

        public Object Retrieve(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }

            Node currentNode = head;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                currentNode = currentNode.Next;
                currentIndex++;
            }

            return currentNode.Data;
        }

        public int IndexOf(object data)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(object data)
        {
            return IndexOf(data) != -1;
        }
    }
}
        
        
   

