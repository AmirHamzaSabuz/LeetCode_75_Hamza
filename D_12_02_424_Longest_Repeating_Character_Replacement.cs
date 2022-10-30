internal class D_12_02_424_Longest_Repeating_Character_Replacement
{
    /*
    private static void Main(string[] args)
    {       
        ////int i1 = CharacterReplacement("AABABBA", 1);       
        ////Console.WriteLine("AABABBA 1 = " + i1);

        ////Console.WriteLine();
        ////int i2 = CharacterReplacement("ABAB", 2);
        ////Console.WriteLine("ABAB 2 = " + i2);

        ////Console.WriteLine();
        ////int i3 = CharacterReplacement("ABABA", 2);
        ////Console.WriteLine("ABABA 2 = " + i3);

        //Console.WriteLine();
        //int i4 = CharacterReplacement("AABABAB", 1);
        //Console.WriteLine("AABABAB 1 = " + i4);

        Console.WriteLine();
        Console.WriteLine("BBABABA, 1");
        int i5 = CharacterReplacement("BBABABA", 1);
        Console.WriteLine("result of (BBABABA, 1) = " + i5);

        //Console.WriteLine();
        //Console.WriteLine("BBABBAA, 1");
        //int i6 = CharacterReplacement("BBABBAA", 1);
        //Console.WriteLine("BBABBAA 1 = " + i6);
    }
    public static int CharacterReplacement(string s, int k)
    {
        int len = s.Length;
        Console.WriteLine("len means s.Length = " + len);
        int[] count = new int[26];
        int start = 0, maxCount = 0, maxLength = 0;
        for (int end = 0; end < len; end++)
        {
            Console.WriteLine();
            Console.WriteLine("line 40. end= " + end);
            Console.WriteLine("line 41. s[end]= " + s[end]);
            Console.WriteLine("line 42. Ascii value of s[end] = " + Convert.ToInt32(s[end]));
            Console.WriteLine("line 43. Ascii value of 'A' = " + Convert.ToInt32('A'));
            Console.WriteLine("line 44. s[end] - 'A' = " + (s[end] - 'A'));
            Console.WriteLine("line 45. count[s[end] - 'A'] = " + count[s[end] - 'A']);
            Console.WriteLine("line 46. maxCount = " + maxCount);

            Console.Write("line 48. Count = ");
            foreach (var c in count)
            {
                Console.Write(c + ", ");
            }
            Console.WriteLine();

            maxCount = Math.Max(maxCount, ++count[s[end] - 'A']); //actual code
            Console.WriteLine(" line 56. maxCount = Math.Max(maxCount, ++count[s[end] - 'A']); ");
            Console.WriteLine("line 57. after Change, count[s[end] - 'A'] = " + count[s[end] - 'A']);
            Console.WriteLine("line 58. after Change, maxCount = " + maxCount);

            Console.Write("line 60. Count = ");
            foreach (var c in count)
            {
                Console.Write(c + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("end - start + 1 means size of the current window");
            Console.WriteLine("line 68. Size of the current window is (end - start + 1) = " + (end - start + 1));
            Console.WriteLine("When ((end-start + 1) - maxCount == 0) or ((end-start + 1) == maxCount))  then the window is filled with only one character");
            Console.WriteLine("((end - start + 1) - maxCount) = " + (end - start + 1 - maxCount));
            Console.WriteLine("When ((end-start+1) - maxCount > 0) or ( (end-start+1) > maxCount)  then we have characters in the window that are NOT the character that occurs the most.");
            Console.WriteLine("( (end-start+1) - maxCount )  equal to exactly the number of characters that are NOT the character that occurs the most in that window.");
            Console.WriteLine("We are allowed to have at most k replacements in the window, ");
            Console.WriteLine("so when ((end - start + 1) - maxCount) > k, then there are more characters in the window than we can replace, ");
            Console.WriteLine("and we need to shrink the window.");
            Console.WriteLine("line 76. end = " + end + ", start = " + start + ", maxCount = " + maxCount + ", k = " + k);
            Console.WriteLine("line 77. Size of the current window is (end - start + 1) = " + (end - start + 1));
            Console.WriteLine("((end - start + 1) - maxCount) = " + (end - start + 1 - maxCount));
            Console.WriteLine(" while (end - start + 1 - maxCount > k)");
            Console.WriteLine();
            while (end - start + 1 - maxCount > k) // actual code
            {
                Console.WriteLine("line 83. end = " + end + ", start = " + start + ", maxCount = " + maxCount + ", k = " + k);
                Console.WriteLine("line 84. end - start + 1 - maxCount = " + (end - start + 1 - maxCount));
                Console.WriteLine();
                Console.WriteLine("line 86. s[start] = " + s[start]);
                Console.WriteLine("line 87. s[start] - 'A' = " + (s[start] - 'A'));
                Console.WriteLine("line 88. count[s[start] - 'A'] = " + (count[s[start] - 'A']));

                Console.Write("line 90. Count = ");
                foreach (var c in count)
                {
                    Console.Write(c + ", ");
                }
                Console.WriteLine();

                count[s[start] - 'A']--; // actual code
                Console.WriteLine(" count[s[start] - 'A']--; ");
                Console.WriteLine("line 99. after change, count[s[start] - 'A'] = " + (count[s[start] - 'A']));

                Console.Write("line 101. Count = ");
                foreach (var c in count)
                {
                    Console.Write(c + ", ");
                }
                Console.WriteLine();

                Console.WriteLine("line 108. start " + start);
                start++; // actual code
                Console.WriteLine("start++;");
                Console.WriteLine("line 111. start " + start);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("line 115. maxLength = " + maxLength + ", end = " + end + ", start = " + start);
            Console.WriteLine("line 116. end - start + 1 = " + (end - start + 1));
            maxLength = Math.Max(maxLength, end - start + 1); // actual code
            Console.WriteLine("maxLength = Math.Max(maxLength, end - start + 1);");
            Console.WriteLine("line 119. after change, maxLength = " + maxLength);
        }
        Console.WriteLine("line 121. return maxLength = " + maxLength);
        return maxLength; // actual code
        
    }
    */

    public static int CharacterReplacement(string s, int k)
    {
        int len = s.Length;
        int[] count = new int[26];
        int start = 0, maxCount = 0, maxLength = 0;
        for (int end = 0; end < len; end++)
        {
            maxCount = Math.Max(maxCount, ++count[s[end] - 'A']);
            while (end - start + 1 - maxCount > k)
            {
                count[s[start] - 'A']--;
                start++;
            }
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        return maxLength;
    }

}

/*
Explanation:
end - start + 1 = size of the current window
maxCount = largest count of a single, unique character in the current window
The main equation is: end - start + 1 - maxCount
When end-start+1-maxCount== 0, then the window is filled with only one character

When end-start+1-maxCount> 0, then we have characters in the window that are NOT the character that occurs the most. 
end-start+1-maxCount equal to exactly the # of characters that are NOT the character that occurs the most in that window.
We are allowed to have at most k replacements in the window, so when end - start + 1 - maxCount > k, then there are more characters in the window than we can replace, and we need to shrink the window.


maxCountmay be invalid at some points, but this doesn't matter, because it was valid earlier in the string, 
and all that matters is finding the max window that occurred anywhere in the string. 
Additionally, it will expand _if and only if _enough repeating characters appear in the window to make it expand. 
So whenever it expands, it's a valid expansion.
*/



/*
 424. Longest Repeating Character Replacement
You are given a string s and an integer k. 
You can choose any character of the string and change it to any other uppercase English character. 
You can perform this operation at most k times.

Return the length of the longest substring containing the same letter 
you can get after performing the above operations.

Example 1:

Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.

Example 2:
Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
*/
