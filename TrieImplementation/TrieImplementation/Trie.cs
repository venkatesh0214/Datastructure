using System;
using System.Collections.Generic;

namespace TrieImplementation
{

    public class Trie
    {
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void insert(string input)
        {
           
            TrieNode tempNode = root;
            int i=0;
            foreach (char c in input)
            {
                TrieNode newNode;
                if (tempNode.children.ContainsKey(c))
                {
                    tempNode = tempNode.children[c];
                }
                else
                {
                    newNode = new TrieNode();
                    tempNode.children.Add(c, newNode);
                    Console.WriteLine("New node with char "+ c + " added ");
                    tempNode = newNode;
                }
                i++;
                if (i == input.Length)
                {
                    tempNode.isEndOfWord = true;
                    Console.WriteLine(c + " is the end of word");
                }

            }

        }

    }

    public class TrieNode
    {
        public Dictionary <char,TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isEndOfWord;

        public TrieNode()
        {

        }
    }

}
