using System;
using System.Collections.Generic;
namespace CombinationProblem
{
    public class PalindromeCheck
    {
        //Write an efficient method that checks whether any permutation of given sring is palindrome
        public bool checkpalindrome(string input)
        {

            HashSet<Char> set = new HashSet<Char>();
            
            Char[] charArray = input.ToCharArray();

            bool isEven = charArray.Length % 2 == 0 ? true : false;

            Console.WriteLine(input +"  set.Count : " + set.Count +  "evenOrOdd "+ isEven.ToString());

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!set.Contains(charArray[i]))
                    set.Add(charArray[i]);
                else
                    set.Remove(charArray[i]);
            }

            foreach (char a in set)
            {
                Console.WriteLine(a);

            }


            if (isEven)
                if (set.Count == 0)
                    return true;
                else
                    return false;
            else
                if (set.Count == 1)
                    return true;
                else
                    return false;

        }
    }
}
