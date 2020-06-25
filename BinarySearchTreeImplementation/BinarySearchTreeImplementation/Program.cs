using System;

namespace BinarySearchTreeImplementation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BST !");
            BinarySearchTree bst = new BinarySearchTree();
            bst.insert(8);
            bst.insert(6);
            bst.insert(14);
            bst.insert(9);
            bst.insert(7);
            bst.insert(5);
            Console.WriteLine("BST values ! ");
            bst.display();

            Console.WriteLine("bst.search(6) " + bst.search(6).ToString());
            Console.WriteLine("bst.search(8) " + bst.search(8).ToString());
            Console.WriteLine("bst.search(14) " + bst.search(14).ToString());
            Console.WriteLine("bst.search(9) " + bst.search(9).ToString());
            Console.WriteLine("bst.search(7) " + bst.search(7).ToString());
            Console.WriteLine("bst.search(5) " + bst.search(5).ToString());
            Console.WriteLine("bst.search(30) " + bst.search(3).ToString());
            Console.WriteLine("bst.search(21) " + bst.search(21).ToString());
            Console.WriteLine("bst.search(3) " + bst.search(3).ToString());
            Console.ReadLine();
        }
    }


}
