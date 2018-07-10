using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree searchTree = new Tree();
            searchTree.AddNode(20);
            searchTree.AddNode(15);
            searchTree.AddNode(42);
            bool found = searchTree.Search(42);
        }
    }
}
