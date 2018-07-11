﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Tree<T>
    {
        // Member Variables
        private Node<T> rootNode;
        private Node<T> tempNode;
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
                tempNode = rootNode;
                if (Comparer<T>.Default.Compare(node.value, rootNode.value) < 0)
                {
                    CheckLeftNode(node, tempNode);
                }
                else
                {
                    CheckRightNode(node, tempNode);
                }
            }
            
        }
        private void CheckLeftNode(Node<T> node, Node<T> tempNode)
        {
            T temp = tempNode.value;
            while(node.parentNode == null)
            {
                if (Comparer<T>.Default.Compare(node.value, temp) < 0 && tempNode.childLeft == null)
                {
                    node.parentNode = tempNode;
                    tempNode.childLeft = node;
                }
                else if(Comparer<T>.Default.Compare(node.value, temp) < 0 && tempNode.childLeft != null)
                {
                    CheckLeftNode(node, tempNode.childLeft);
                }
                else if(Comparer<T>.Default.Compare(node.value, temp) >= 0)
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
                if (Comparer<T>.Default.Compare(node.value, temp) >= 0 && tempNode.childRight == null)
                {
                    node.parentNode = tempNode;
                    tempNode.childRight = node;
                }
                else if(Comparer<T>.Default.Compare(node.value, temp) >= 0 && tempNode.childRight != null)
                {
                    CheckRightNode(node, tempNode.childRight);
                }
                else if (Comparer<T>.Default.Compare(node.value, temp) < 0)
                {
                    CheckLeftNode(node, tempNode);
                }
            }
        }
        public bool Search(T value)
        {
            if (Comparer<T>.Default.Compare(value, rootNode.value) < 0 && rootNode.childLeft != null)
            {
                return LeftNodeSearch(value, rootNode.childLeft);
            }
            else if (Comparer<T>.Default.Compare(value, rootNode.value) < 0 && rootNode.childLeft == null)
            {
                return false;
            }
            else if (Comparer<T>.Default.Compare(value, rootNode.value) > 0 && rootNode.childRight != null)
            {
                return RightNodeSearch(value, rootNode.childRight);
            }
            else if (Comparer<T>.Default.Compare(value, rootNode.value) > 0 && rootNode.childRight == null)
            {
                return false;
            }
            else if(Comparer<T>.Default.Compare(value, rootNode.value) == 0)
            {
                return true;
            }
            return false;
        }
        public bool LeftNodeSearch(T value, Node<T> curParentNode)
        {
            if(Comparer<T>.Default.Compare(value, curParentNode.value) == 0)
            {
                return true;
            }
            else if(Comparer<T>.Default.Compare(value, curParentNode.value) > 0 && curParentNode.childLeft != null)
            {
                LeftNodeSearch(value, curParentNode.childLeft);
            }
            else if(Comparer<T>.Default.Compare(value, curParentNode.value) > 0 && curParentNode.childLeft == null)
            {
                return false;
            }
            else if(Comparer<T>.Default.Compare(value, curParentNode.value) < 0 && curParentNode.childLeft != null)
            {
                RightNodeSearch(value, curParentNode.childRight);
            }
            else if(Comparer<T>.Default.Compare(value, curParentNode.value) < 0 && curParentNode.childLeft == null)
            {
                return false;
            }
            return false;
        }
        public bool RightNodeSearch(T value, Node<T> curParentNode)
        {
            if (Comparer<T>.Default.Compare(value, curParentNode.value) == 0)
            {
                return true;
            }
            else if (Comparer<T>.Default.Compare(value, curParentNode.value) > 0 && curParentNode.childLeft != null)
            {
                LeftNodeSearch(value, curParentNode.childLeft);
            }
            else if (Comparer<T>.Default.Compare(value, curParentNode.value) > 0 && curParentNode.childLeft == null)
            {
                return false;
            }
            else if (Comparer<T>.Default.Compare(value, curParentNode.value) < 0 && curParentNode.childLeft != null)
            {
                RightNodeSearch(value, curParentNode.childRight);
            }
            else if (Comparer<T>.Default.Compare(value, curParentNode.value) < 0 && curParentNode.childLeft == null)
            {
                return false;
            }
            return false;
        }
    }
}
