using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                tree.Add(random.Next(101));
            }
            tree.Add(50);

            tree.Search(50);
            Console.ReadLine();
        }
    }
}
