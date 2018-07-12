using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Node<T>
    {
        public T value;
        public Node<T> parentNode;
        public Node<T> childLeft;
        public Node<T> childRight;
        public Node(T value)
        {
            this.value = value;
            parentNode = null;
            childLeft = null;
            childRight = null;
        }
    }
}
