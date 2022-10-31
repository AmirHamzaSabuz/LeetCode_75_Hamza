internal class D_14_01_844_Backspace_String_Compare
{
    private static void Main(string[] args)
    {
        bool result;
        /*
        Console.WriteLine();       
        Console.WriteLine();
        Console.WriteLine(" \"ab#c\", \"ad#c\" ");
        result = BackspaceCompare("ab#c", "ad#c");
        Console.WriteLine(result);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" \"a#c\", \"b\" ");
        result = BackspaceCompare("a#c", "b");
        Console.WriteLine(result);
        */
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" \"bxj##tw\", \"bxj###tw\" ");
        result = BackspaceCompare("bxj##tw", "bxj###tw");
        Console.WriteLine(result);

    }
    /* //Explanation of process-1
    public static bool BackspaceCompare(string S, string T)
    {
        var i = S.Length - 1;
        var j = T.Length - 1;
        var skipS = 0;
        var skipT = 0;
        Console.WriteLine("S.Length = " + S.Length + ", T.Length = " + T.Length);
        Console.WriteLine("i = S.Length - 1;");
        Console.WriteLine("j = T.Length - 1;");
        Console.WriteLine("i = " + i);
        Console.WriteLine("j = " + j);
        Console.WriteLine(" while (i >= 0 || j >= 0) ");
        while (i >= 0 || j >= 0)
        {
            Console.WriteLine("");
            Console.WriteLine(" Now in the loop. while (i >= 0 || j >= 0) ");
            Console.WriteLine("i = " + i + ", j = " + j);

            Console.WriteLine("while (i >= 0)");
            while (i >= 0)
            {
                Console.WriteLine(" Now in the loop. while (i >= 0) ");
                Console.WriteLine("S[i] = " + S[i]);
                Console.WriteLine("if (S[i] == '#')");
                if (S[i] == '#')
                {
                    Console.WriteLine("(S[i] == '#') condition true. In if block");
                    Console.WriteLine("skipS = " + skipS);
                    Console.WriteLine("skipS++;");
                    skipS++;
                    Console.WriteLine("skipS = " + skipS);
                }
                else if (skipS > 0)
                {
                    Console.WriteLine("(skipS > 0) true. In else if block");
                    Console.WriteLine("skipS = " + skipS);
                    Console.WriteLine("skipS--;");
                    skipS--;
                    Console.WriteLine("skipS = " + skipS);
                }
                else
                {
                    Console.WriteLine("(S[i] == '#') is false and (skipS > 0) is false. In else block");
                    Console.WriteLine("break;");
                    break;
                }
                Console.WriteLine("end if else");
                Console.WriteLine("i = " + i);
                Console.WriteLine("i--;");
                i--;
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("end while (i >= 0)");

            Console.WriteLine("");
            Console.WriteLine("i = " + i + ", j = " + j);
            Console.WriteLine("while (j >= 0)");
            while (j >= 0)
            {
                Console.WriteLine(" Now in the loop. while (j >= 0) ");
                Console.WriteLine("T[j] = " + T[j]);
                Console.WriteLine("if (T[j] == '#')");
                if (T[j] == '#')
                {
                    Console.WriteLine("(T[j] == '#') condition true. In if block");
                    Console.WriteLine("skipT = " + skipT);
                    Console.WriteLine("skipT++;");
                    skipT++;
                    Console.WriteLine("skipT = " + skipT);
                }
                else if (skipT > 0)
                {
                    Console.WriteLine("(skipT > 0) true. In else if block");
                    Console.WriteLine("skipT = " + skipT);
                    Console.WriteLine("skipT--;");
                    skipT--;
                    Console.WriteLine("skipT = " + skipT);
                }
                else
                {
                    Console.WriteLine("(T[j] == '#') is false and (skipT > 0) is false. In else block");
                    Console.WriteLine("break;");
                    break;
                }
                Console.WriteLine("end if else");
                Console.WriteLine("j = " + j);
                Console.WriteLine("j--;");
                j--;
                Console.WriteLine("j = " + j);
            }
            Console.WriteLine("end while (j >= 0)");

            Console.WriteLine("");
            Console.WriteLine("i = " + i + ", j = " + j );
            if (i >= 0)
            {
                Console.WriteLine("S[i] = " + S[i]);
            }
            if (j >= 0)
            {
                Console.WriteLine("T[j] = " + T[j]);
            }
            Console.WriteLine("if (i >= 0 && j >= 0 && S[i] != T[j])");
            if (i >= 0 && j >= 0 && S[i] != T[j])
            {
                Console.WriteLine("if (i >= 0 && j >= 0 && S[i] != T[j]) condition true. return false");
                return false;
            }
            Console.WriteLine("condition false. end if (i >= 0 && j >= 0 && S[i] != T[j])");

            Console.WriteLine("");
            Console.WriteLine("i = " + i + ", j = " + j);
            Console.WriteLine("if ((i >= 0) != (j >= 0))");
            if ((i >= 0) != (j >= 0))
            {
                Console.WriteLine("if ((i >= 0) != (j >= 0)) condition true. return false");
                return false;
            }
            Console.WriteLine("condition false. end if ((i >= 0) != (j >= 0))");

            Console.WriteLine("");

            Console.WriteLine("i = " + i + ", j = " + j);
            Console.WriteLine("i--; j--;");
            i--; j--;
            Console.WriteLine("i = " + i + ", j = " + j);
        }
        Console.WriteLine("end while (i >= 0 || j >= 0)");
        Console.WriteLine("return true;");
        return true;
    }
    */

    /* // Orginal code of process-1
    public static bool BackspaceCompare(string S, string T)
    {
        var i = S.Length - 1;
        var j = T.Length - 1;
        var skipS = 0;
        var skipT = 0;

        while (i >= 0 || j >= 0)
        {
            while (i >= 0)
            {
                if (S[i] == '#')
                    skipS++;
                else if (skipS > 0)
                    skipS--;
                else
                    break;
                i--;
            }
            while (j >= 0)
            {
                if (T[j] == '#')
                    skipT++;
                else if (skipT > 0)
                    skipT--;
                else
                    break;
                j--;
            }

            if (i >= 0 && j >= 0 && S[i] != T[j]) return false;
            if ((i >= 0) != (j >= 0)) return false;
            i--; j--;
        }

        return true;
    }
    */


    /* // Explanation of process-2
    public static bool BackspaceCompare(string S, string T)
    {
        int sIndex = S.Length, tIndex = T.Length;
        while (true)
        {
            sIndex = GetValidCharacterIndex(S, sIndex - 1);
            tIndex = GetValidCharacterIndex(T, tIndex - 1);

            if (sIndex < 0 && tIndex < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("(sIndex < 0 && tIndex < 0) true. return true");
                return true;
            }

            if (sIndex < 0 || tIndex < 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" (sIndex < 0 || tIndex < 0) true. return false");
                return false;
            }

            if (S[sIndex] != T[tIndex])
            {
                Console.WriteLine("");
                Console.WriteLine("(S[sIndex] != T[tIndex]) true. return false");
                return false;
            }
        }
    }


    static int GetValidCharacterIndex(string str, int lastIndex)
    {
        int skipCount = 0;
        while (lastIndex >= 0)
        {
            if (str[lastIndex] == '#')
            {
                skipCount++;
            }
            else
            {
                if (skipCount > 0)
                {
                    skipCount--;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("(str[lastIndex] == '#') false and (skipCount > 0) false. return lastIndex");
                    Console.WriteLine("lastIndex = " + lastIndex);
                    return lastIndex;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("lastIndex = " + lastIndex);
            Console.WriteLine("lastIndex--;");
            lastIndex--;
            Console.WriteLine("lastIndex = " + lastIndex);
        }
        Console.WriteLine("");
        Console.WriteLine("end while (lastIndex >= 0). return lastIndex ");
        Console.WriteLine("lastIndex = " + lastIndex);
        return lastIndex;
    }
    */

    // Orginal code of process-2
    public static bool BackspaceCompare(string S, string T)
    {
        int sIndex = S.Length, tIndex = T.Length;
        while (true)
        {
            sIndex = GetValidCharacterIndex(S, sIndex - 1);
            tIndex = GetValidCharacterIndex(T, tIndex - 1);

            if (sIndex < 0 && tIndex < 0) return true;

            if (sIndex < 0 || tIndex < 0) return false;

            if (S[sIndex] != T[tIndex]) return false;
        }
    }

    static int GetValidCharacterIndex(string str, int lastIndex)
    {
        int skipCount = 0;
        while (lastIndex >= 0)
        {
            if (str[lastIndex] == '#')
            {
                skipCount++;
            }
            else
            {
                if (skipCount > 0)
                {
                    skipCount--;
                }
                else
                {
                    return lastIndex;
                }
            }

            lastIndex--;
        }

        return lastIndex;
    }

}

/*
844.Backspace String Compare

Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

 

Example 1:

Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".
Example 2:

Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".
Example 3:

Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".

*/