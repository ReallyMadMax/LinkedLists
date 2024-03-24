using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    // Node class is defined as generic class to allow store any data type
    public class Node
    {
        // Data or value stored in the node.
        public object Data { get; set; }

        // Reference to the next node in the linked list.
        public Node Next { get; set; }

        // Node class constructor
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
