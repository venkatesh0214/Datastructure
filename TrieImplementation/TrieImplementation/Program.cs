using System;

namespace TrieImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trie World!");

            Trie t = new Trie();
            string s = "Visakan";

            Console.WriteLine("Word Length"+s.Length);
            t.insert("visakan");
            t.insert("visak");

            Console.ReadLine();
        }
    }
}
