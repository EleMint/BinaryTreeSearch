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
            Tree<int> searchTree = new Tree<int>();
            searchTree.AddNode(20);
            searchTree.AddNode(15);
            searchTree.AddNode(42);
            searchTree.AddNode(12);
            searchTree.AddNode(13);
            searchTree.AddNode(30);
            bool found1 = searchTree.Search(15);
            bool found2 = searchTree.Search(100);
            Console.WriteLine($"Found 15: {found1}  Found 100: {found2}");
            Console.ReadLine();
        }
    }
}
