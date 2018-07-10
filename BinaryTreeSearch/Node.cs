﻿using System;
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
        public Node<T> parentNode;
        public Node<T> childLeft;
        public Node<T> childRight;
        // Constructor
        public Node(T value)
        {
            this.value = value;
            parentNode = null;
            childLeft = null;
            childRight = null;
        }
    }
}
