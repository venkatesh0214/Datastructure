using System;
using System.Collections.Generic;

namespace CombinationProblem
{
    public class StringCombination
    {
        public StringCombination()
        {
        }

        public static ISet<string> GetPermutations(string inputString)
        {
            // Base case
            if (inputString.Length <= 1)
            {
                return new HashSet<string>() { inputString };
            }

            var allCharsExceptLast = inputString.Substring(0, inputString.Length - 1);
            char lastChar = inputString[inputString.Length - 1];

            // Recursive call: get all possible permutations for all chars except last
            var permutationsOfAllCharsExceptLast = GetPermutations(allCharsExceptLast);

            // Put the last char in all possible positions for each of the above permutations
            var permutations = new HashSet<string>();
            foreach (var permutationOfAllCharsExceptLast in permutationsOfAllCharsExceptLast)
            {
                for (int position = 0; position <= allCharsExceptLast.Length; position++)
                {
                    var permutation = permutationOfAllCharsExceptLast.Substring(0, position)
                        + lastChar + permutationOfAllCharsExceptLast.Substring(position);
                    permutations.Add(permutation);
                }
            }

            return permutations;
        }

        public static void GetPermutations(string inputString, bool isPrint)
        {
            HashSet<string> s = new HashSet<string>();
            s = (HashSet<string>)GetPermutations(inputString);

            int i = 1;
            foreach (string s1 in s)
            {
                Console.WriteLine(i+"  -  "+s1);
                i++;
            }

        }

           
    }
}
