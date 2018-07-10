using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Node<T>
    {
        // Member Variables
        public T value;
        public Node<T> link;
        // Constructor
        public Node(T value)
        {
            this.value = value;
            link = null;
        }
    }
}
