using System;
using System.Collections.Generic;
using System.Linq;

namespace StringRelatedProblem
{
    public class FirstUniqueChar
    {
        public int FirstUniqCharFun(string s)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                  dict[s[i]] = -1;
                else
                    dict[s[i]] = i;
            }

            var kvp = dict.ToList();
            kvp.Sort((k1, k2) => k1.Value.CompareTo(k2.Value));
            kvp = kvp.Where(a => a.Value > -1).ToList();

            return kvp.Count == 0 ? -1 : kvp.First().Value;
        }
    }
}
