internal class D_12_01_438_Find_All_Anagrams_in_a_String 
{
    /*
    private static void Main(string[] args)
    {       
        IList<int> list = new List<int>();
        list = FindAnagrams("cbaebabacd", "abc");
        Console.WriteLine();

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("The substring with start index = " + list[i]);
        }
        Console.ReadKey();
    }
    
    public static IList<int> FindAnagrams(string s, string p)
    {
        var sLength = s.Length;
        var pLength = p.Length;
        var pCount = new int[26];

        for (int i = 0; i < pCount.Length; i++) //for understanding
        {
            Console.WriteLine("line 25. pCount[i]= " + pCount[i]);
        }
        Console.WriteLine(); //for understanding
        Console.WriteLine("foreach (var ch in p){pCount[ch - 'a']++; }"); //for understanding
        foreach (var ch in p) // Actual Code
        {
            pCount[ch - 'a']++; // Actual Code
        }
        for (int i = 0; i < pCount.Length; i++) //for understanding
        {
            Console.WriteLine("line 35. pCount[i] " + pCount[i]); //for understanding
        }
        Console.WriteLine(); //for understanding
        var sCount = new int[26];
        var result = new List<int>();
        for (int i = 0; i < sLength; i++)
        {
            Console.WriteLine();
            Console.WriteLine( "line 43. i= " + i + ", s[i]= " + s[i]);
            Console.WriteLine("ascii value of s[i]= " + Convert.ToInt32(s[i]) );
            Console.WriteLine("s[i] - 'a' = " + (s[i] - 'a'));
            Console.WriteLine("line 46. sCount[s[i] - 'a'] = " + sCount[s[i] - 'a']);
            sCount[s[i] - 'a']++;
            Console.WriteLine("sCount[s[i] - 'a']++;");
            Console.WriteLine("line 49. s[i]= " + s[i]);
            Console.WriteLine("s[i] - 'a' = " + (s[i] - 'a'));
            Console.WriteLine("line 51. sCount[s[i] - 'a'] = " + sCount[s[i] - 'a']);
            Console.WriteLine();
            if (i >= pLength)
            {
                Console.WriteLine("line 55. i >= pLength");
                Console.WriteLine("line 56. i = " + i);
                Console.WriteLine("line 57. i - pLength = " + (i - pLength));
                Console.WriteLine("line 58. s[i - pLength] = " + (s[i - pLength]));
                Console.WriteLine("line 59. s[i - pLength] - 'a' = " + (s[i - pLength] - 'a'));
                Console.WriteLine("line 60. sCount[ s[i-pLength]-'a' ] = " + sCount[ s[i-pLength]-'a' ] );
                sCount[s[i - pLength] - 'a']--;
                Console.WriteLine("sCount[s[i - pLength] - 'a']--;");
                Console.WriteLine("line 63. sCount[ s[i - pLength] - 'a' ] = " + sCount[ s[i - pLength] - 'a' ]);
            }
            Console.WriteLine();
            Console.Write("sCount = ");
            foreach (var v in sCount) //for understanding
            {
                Console.Write( v + ", ");
            }
            Console.WriteLine();
            Console.Write("pCount = ");
            foreach (var v in pCount) //for understanding
            {
                Console.Write( v + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("line 78. i= " + i);
            Console.WriteLine("pLength = " + pLength);
            Console.WriteLine("line 80. i - pLength + 1 = " + (i - pLength + 1));
            
            if (Enumerable.SequenceEqual(sCount, pCount))
            {
                Console.WriteLine("line 84. Enumerable.SequenceEqual(sCount, pCount)");
                result.Add(i - pLength + 1);
                Console.WriteLine("line 86. result.Add(i - pLength + 1)");
            }
        }

        return result;
    }
    */

    public IList<int> FindAnagrams(string s, string p)
    {
        var sLength = s.Length;
        var pLength = p.Length;

        var pCount = new int[26];
        foreach (var ch in p)
            pCount[ch - 'a']++;

        var sCount = new int[26];
        var result = new List<int>();
        for (int i = 0; i < sLength; i++)
        {
            sCount[s[i] - 'a']++;
            if (i >= pLength)
                sCount[s[i - pLength] - 'a']--;

            if (Enumerable.SequenceEqual(sCount, pCount))
                result.Add(i - pLength + 1);
        }

        return result;
    }


}

/*
 438. Find All Anagrams in a String

Given two strings s and p, return an array of all the start indices of p's anagrams in s. 
You may return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
typically using all the original letters exactly once.

 

Example 1:

Input: s = "cbaebabacd", p = "abc"
Output: [0,6]
Explanation:
The substring with start index = 0 is "cba", which is an anagram of "abc".
The substring with start index = 6 is "bac", which is an anagram of "abc".
Example 2:

Input: s = "abab", p = "ab"
Output: [0,1,2]
Explanation:
The substring with start index = 0 is "ab", which is an anagram of "ab".
The substring with start index = 1 is "ba", which is an anagram of "ab".
The substring with start index = 2 is "ab", which is an anagram of "ab".

*/