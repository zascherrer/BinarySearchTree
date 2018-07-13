using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int key)
        {
            Node node = new Node();
            node.key = key;
            if(root == null)
            {
                root = node;
            }
            else
            {
                Insert(node);
            }
        }

        private void Insert(Node node)
        {
            Node currentNode = root;
            Node parent;

            while (true)
            {
                parent = currentNode;
                if (node.key < currentNode.key)
                {
                    currentNode = currentNode.left;
                    if(currentNode == null)
                    {
                        parent.left = node;
                        return;
                    }
                }
                else
                {
                    currentNode = currentNode.right;
                    if(currentNode == null)
                    {
                        parent.right = node;
                        return;
                    }
                }
            }
        }

        public bool Search(int key)
        {
            Node current = root;
            Console.WriteLine(root.key);
            while (true)
            {
                if (current == null)
                {
                    Console.WriteLine("Key not found.");
                    return false;
                }

                if (key == current.key)
                {
                    Console.WriteLine("Key found!");
                    return true;
                }
                else if(key < current.key)
                {
                    current = current.left;
                    Console.WriteLine("Left!");
                }
                else
                {
                    current = current.right;
                    Console.WriteLine("Right!");
                }
            }
        }
    }
}
