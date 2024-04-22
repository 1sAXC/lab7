using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Tree
    {

        internal class Node
        {
            public Node leftNode;
            public Node rightNode;
            public int? value;
        }

        Node root;
        int count;


        public Tree()
        {
            root = new Node();
        }

        public static Tree CreateEmptyTree()
        {
            return new Tree();
        }

        public bool IsEmpty()
        {
            return this.count == 0;
        }

        public void AddToTree(int data)
        {
            if (count == 0)
            {
                root.value = data;
                count++;
                return;
            }
            count++;
            AddRecursive(data, root);
        }

        private void AddRecursive(int data, Node node)
        {
            if (node.value == null)
            {
                node.value = data;
                return;
            }

            if (data < node.value)
            {
                if (node.leftNode == null)
                {
                    node.leftNode = new Node();
                }
                AddRecursive(data, node.leftNode);
            }
            else
            {
                if (node.rightNode == null)
                {
                    node.rightNode = new Node();
                }
                
                AddRecursive(data, node.rightNode);
            }
        }

        public static Tree CreateTree(int minValue, int maxValue, int count)
        {
            Random random = new Random();
            Tree returnTree = CreateEmptyTree();
            for (int i = 0; i < count; i++)
            {
                int data = random.Next(minValue, maxValue + 1);
                returnTree.AddToTree(data);
                Console.Write($"{data} ");
            }

            return returnTree;
        }      
        
        public void PrintTopDown()
        {

            if (count == 0)
            {
                Console.WriteLine("Дерево пусто");
                return;
            }
            PrintTopDownRecursive(root);
        }

        private void PrintTopDownRecursive(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.value.ToString() + " ");


            PrintTopDownRecursive(node.leftNode);
            PrintTopDownRecursive(node.rightNode);

        }

        public void LeftToRight()
        {

            if (count == 0)
            {
                Console.WriteLine("Дерево пусто");
                return;
            }
            LeftToRightRecursive(root);
        }

        private void LeftToRightRecursive(Node node)
        {
            if (node == null)
            {
                return;
            }       

            LeftToRightRecursive(node.leftNode);
            Console.Write(node.value.ToString() + " ");
            LeftToRightRecursive(node.rightNode);
        }

        public void DownTop()
        {

            if (count == 0)
            {
                Console.WriteLine("Дерево пусто");
                return;
            }
            DownTopRecursive(root);
        }

        private void DownTopRecursive(Node node)
        {
            if (node == null)
            {
                return;
            }       

            DownTopRecursive(node.leftNode);
            DownTopRecursive(node.rightNode);
            Console.Write(node.value.ToString() + " ");
        }

        public void DeleteTree()
        {
            root = null;
        }

    }


}
