using System;

public class D_05_02_409_Longest_Palindrome
{
    public int LongestPalindrome(string s)
    {
        int[] lowerCase = new int[26];
        int[] upperCase = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c - 97 >= 0)
            {
                lowerCase[c - 97]++;
            }
            else
            {
                upperCase[c - 65]++;
            }

        }

        int ans = 0;
        bool isFirstOdd = true;
        for (int i = 0; i < 26; i++)
        {
            if (lowerCase[i] % 2 == 0)
            {
                ans += lowerCase[i];
            }
            else
            {
                if (isFirstOdd == true)
                {
                    ans += lowerCase[i];
                    isFirstOdd = false;
                }
                else
                {
                    ans = ans + (lowerCase[i] - 1);
                }
            }
        }



        for (int i = 0; i < 26; i++)
        {
            if (upperCase[i] % 2 == 0)
            {
                ans += upperCase[i];
            }
            else
            {
                if (isFirstOdd == true)
                {
                    ans += upperCase[i];
                    isFirstOdd = false;
                }
                else
                {
                    ans = ans + (upperCase[i] - 1);
                }
            }
        }

        return ans;
    }
}

/*
409. Longest Palindrome

Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

 

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.
 */