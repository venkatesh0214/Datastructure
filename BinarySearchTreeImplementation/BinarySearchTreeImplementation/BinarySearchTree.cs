using System;
namespace BinarySearchTreeImplementation
{
    public class BinarySearchTree
    {
        Node root;

        public  BinarySearchTree()
        {
            this.root = null;   
        }

        public class Node
        {
            public Node right;
            public Node left;
            public int data;
        }


        public void insert(int d)
        {
            Node currentNode;
            Node parent;
            Node newNode = new Node(); 
            newNode.data = d;

            if (root == null)
            {
                root = newNode;
                return;
            }

            currentNode = root;
            parent = root;

            do
            {
                if (currentNode.data < d)
                {
                    parent = currentNode;
                    currentNode = currentNode.right;
                    if (currentNode == null)
                        parent.right = newNode;
                    
                }
                else
                {
                    parent = currentNode;
                    currentNode = currentNode.left;
                    if (currentNode == null)
                        parent.left = newNode;
                }

            } while (currentNode != null);
        }


        public void display()
        {
            Console.WriteLine("InOrder");//sorted format
            inOrder(root);
            Console.WriteLine("PreOrder");
             preOrder(root);
            Console.WriteLine("PostOrder");
            postOrder(root);

        }

        public void inOrder(Node root)
        {
            if (root == null)
                return;

            inOrder(root.left);
            Console.Write(" " + root.data +" ");
            inOrder(root.right);
        }

        public void preOrder(Node root)
        {
            if (root == null)
                return;

            Console.Write(" " + root.data + " ");
            preOrder(root.left);
            preOrder(root.right);
        }

        public void postOrder(Node root)
        {
            if (root == null)
                return;
            
            postOrder(root.left);
            postOrder(root.right);
            Console.Write(" " + root.data + " ");
        }

        public bool search(int d)
        {
            Node currentNode = root;

            if (root.data == d)
            {
                return true;
            }

            do
            {               
                if (currentNode.data < d)
                {
                    currentNode = currentNode.right;
                    if (currentNode!=null && currentNode.data == d)
                    { return true; }
                }
                else
                {
                    currentNode = currentNode.left;
                    if (currentNode!=null &&  currentNode.data == d)
                    { return true; }
                }
            } while (currentNode != null);
        
            return false;
        }
    }
}
