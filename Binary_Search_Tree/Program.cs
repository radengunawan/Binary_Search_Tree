using System;
using System.Collections.Generic;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree btr = new BinaryTree();

            List<int> numberz = new List<int> { 1, 2, 7, 3, 10, 5, 8 };

            foreach (int item in numberz)
            {
                btr.Add(item);
            }

            Node node = btr.Find(5);
            int depth = btr.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            btr.TraversePreOrder(btr.Root);
            Console.WriteLine();

        }
    }
}
