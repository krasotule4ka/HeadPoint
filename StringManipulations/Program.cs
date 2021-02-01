using System;
using System.Text;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var ans = Anagrams.GroupAnagrams(new[] {"ток", "рост", "кот", "торс", "Кто", "фывап", "рок"});
            foreach (var strArr in ans)
                Console.WriteLine(string.Join(" ", strArr));
        }
    }
}