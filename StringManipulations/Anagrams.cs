using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulations
{
    public static class Anagrams
    {
        public static string[][] GroupAnagrams(string[] input)
        {
            if (input == null)
                return Array.Empty<string[]>();
            
            var result = new Dictionary<string, List<string>>();

            foreach (var str in input)
            {
                var chars = str.ToLower().ToCharArray();
                Array.Sort(chars);
                var key = new string(chars);
                if (!result.Keys.Contains(key))
                    result.Add(key, new List<string>());
                result[key].Add(str);
            }

            return result.Select(a => a.Value.ToArray()).ToArray();
        }
    }
}