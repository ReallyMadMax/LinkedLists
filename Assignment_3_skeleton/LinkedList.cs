using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class LinkedList : ILinkedListADT
    {
        // Define refernce/pointer to the first node
        public Node head;
        public int listSize;

        // SLL class constructor 
        // Create empty list
        public LinkedList()
        {
            head = null;
            listSize = 0;
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
    }
}
