using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Tree<T> : IComparer<T>
    {
        // Member Variables
        private Node<T> rootNode;
        //private Node<T> parentNode;
        private Node<T> tempNode;
        //private T tempValue = default(T);
        // Constructor
        public Tree()
        {
            tempNode = null;
        }
        // Member Methods
        public void AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            if (rootNode == null)
            {
                rootNode = node;
                tempNode = rootNode;
            }
            else
            {
                if (node.Compare(node.value, rootNode.value) < 0)
                {
                    CheckLeftNode(node, tempNode);
                }
                else
                {
                    CheckRightNode(node, tempNode);
                }
            }

        }

        

        public bool Search(T value)
        {
            return true;
        }
        private void CheckLeftNode(Node<T> node, Node<T> tempNode)
        {
            T temp = tempNode.value;
            while(node.parentNode == null)
            {
                if (node.IComparer<T>.Compare(node.value, temp) < 0 && tempNode.childLeft == null)
                {
                    node.parentNode = tempNode.childLeft;
                }
                else if(node.Compare(node.value, temp) > 0 || node.Compare(node.value, temp) == 0)
                {
                    CheckRightNode(node, tempNode);
                }
            }
        }
        private void CheckRightNode(Node<T> node, Node<T> tempNode)
        {
            T temp = tempNode.value;
            while (node.parentNode == null)
            {
                if ((node.Compare(node.value, temp) > 0 || node.Compare(node.value, temp) == 0) && tempNode.childLeft == null)
                {
                    node.parentNode = tempNode.childRight;
                }
                else if (node.Compare(node.value, temp) < 0)
                {
                    CheckLeftNode(node, tempNode);
                }
            }
        }

        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}
