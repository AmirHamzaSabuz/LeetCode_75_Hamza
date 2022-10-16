using System;

public class D_02_01_205_Isomorphic_Strings
{
    static int size = 256;
    public bool IsIsomorphic(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        if (m != n)
        {
            return false;
        }

        bool[] marked = new bool[size];

        for (int i = 0; i < size; i++)
        {
            marked[i] = false;
        }

        int[] map = new int[size];

        for (int i = 0; i < size; i++)
        {
            map[i] = -1;
        }

        for (int i = 0; i < n; i++)
        {

            if (map[str1[i]] == -1)
            {
                if (marked[str2[i]] == true)
                {
                    return false;
                }
                marked[str2[i]] = true;

                map[str1[i]] = str2[i];
            }
            else if (map[str1[i]] != str2[i])
            {
                return false;
            }
        }
        return true;
    }
}

/*
 205. Isomorphic Strings

Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

Example 1:

Input: s = "egg", t = "add"
Output: true
Example 2:

Input: s = "foo", t = "bar"
Output: false
Example 3:

Input: s = "paper", t = "title"
Output: true
 */
