using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
    public class LinkedList : ILinkedListADT
    {
        // Define refernce/pointer to the first node
        private Node head;
        private int size;

        // SLL class constructor 
        // Create empty list
        public LinkedList()
        {
            head = null;
            listSize = 0;
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
