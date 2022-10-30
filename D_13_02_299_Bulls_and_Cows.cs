internal class D_13_02_299_Bulls_and_Cows
{   /*
    private static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine(" secret \"1807\", guess \"7810\" ");
        string result1 = GetHint("1807", "7810");
        Console.WriteLine("result1 is " + result1);

        Console.WriteLine();

        Console.WriteLine(" secret \"1123\", guess \"0111\" ");
        string result2 = GetHint("1123", "0111");
        Console.WriteLine("result2 is " + result2);

        Console.WriteLine();

        Console.WriteLine(" secret \"1122\", guess \"1222\"");
        string result3 = GetHint("1122", "1222");
        Console.WriteLine("result3 is " + result3);

        Console.WriteLine();
    }
    
    public static string GetHint(string secret, string guess)
    {
        var counts = new int[10];

        Console.Write("counts = ");
        for (int i = 0; i < counts.Length; i++) // for understanding
        {
            Console.Write(counts[i] + ", ");
        }
        Console.WriteLine();

        foreach (var ch in secret) // actual code
        {
            counts[ch - '0']++;
        }
        Console.WriteLine("foreach (var ch in secret){ counts[ch - '0']++; }");

        Console.Write("counts = ");
        for (int i = 0; i < counts.Length; i++) // for understanding
        {
            Console.Write(counts[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine();
        int a = 0, b = 0;

        Console.WriteLine("for (int i = 0; i < guess.Length; i++)");
        for (int i = 0; i < guess.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine("if (guess[i] == secret[i])");
            if (guess[i] == secret[i])
            {
                Console.WriteLine("(guess[i] == secret[i]) is true. In outer if block");
                Console.WriteLine("a = " + a);
                a++; // bull
                Console.WriteLine("a++;");
                Console.WriteLine("after change a = " + a);

                Console.WriteLine();

                Console.WriteLine("i = " + i + ", guess[i] = " + guess[i] + ", guess[i] - '0' = " + (guess[i] - '0'));
                Console.WriteLine("counts[ guess[i] - '0' ] = " + (counts[ guess[i] - '0' ]) );
                Console.WriteLine("if (counts[guess[i] - '0'] > 0)");
                if (counts[guess[i] - '0'] > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("(counts[guess[i] - '0'] > 0) condition true. In inner if block");
                    Console.WriteLine("counts[ guess[i] - '0' ] = " + (counts[guess[i] - '0']) );
                    counts[guess[i] - '0']--;
                    Console.WriteLine("counts[guess[i] - '0']--;");
                    Console.WriteLine("after change, counts[ guess[i] - '0' ] = " + (counts[guess[i] - '0']));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("(counts[guess[i] - '0'] > 0) condition false. In else block");
                    Console.WriteLine("b = " + b);
                    b--;
                    Console.WriteLine("b--;");
                    Console.WriteLine("after change, b = " + b);
                }
                Console.WriteLine(" continue;");
                continue;
            }
            Console.WriteLine(" (guess[i] == secret[i]) condition not true. end if");
            Console.WriteLine();
            Console.WriteLine("i = " + i + ", guess[i] = " + guess[i]);
            Console.WriteLine("(guess[i] - '0') = " + (guess[i] - '0'));
            Console.WriteLine("(counts[ guess[i] - '0' ]) = " + (counts[ guess[i] - '0' ]) );
            Console.WriteLine(" if (counts[guess[i] - '0'] > 0)");
            if (counts[guess[i] - '0'] > 0)
            {
                Console.WriteLine();
                Console.WriteLine(" (counts[guess[i] - '0'] > 0) condition is true. In if block");
                Console.WriteLine("b = " + b);
                b++;
                Console.WriteLine("b++;");
                Console.WriteLine("b = " + b);

                Console.WriteLine();

                Console.WriteLine("i = " + i + ", guess[i] = " + guess[i]);
                Console.WriteLine("(guess[i] - '0') = " + (guess[i] - '0'));
                Console.WriteLine("(counts[ guess[i] - '0' ]) = " + (counts[guess[i] - '0']));
                Console.WriteLine("counts[guess[i] - '0']--;");
                counts[guess[i] - '0']--;
                Console.WriteLine("after change, (counts[ guess[i] - '0' ] ) = " + (counts[guess[i] - '0']));


            }
        }
        Console.WriteLine();
        Console.WriteLine("return $\"{a}A{b}B\";");
        return $"{a}A{b}B";
    }
    */

    public static string GetHint(string secret, string guess)
    {
        var counts = new int[10];
        foreach (var ch in secret)
        {
            counts[ch - '0']++;
        }

        int a = 0, b = 0;
        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == secret[i])
            {
                a++;
                if (counts[guess[i] - '0'] > 0)
                {
                    counts[guess[i] - '0']--;
                }
                else
                {
                    b--;
                }
                continue;
            }

            if (counts[guess[i] - '0'] > 0)
            {
                b++;
                counts[guess[i] - '0']--;
            }
        }

        return $"{a}A{b}B";
    }

}

/*
 299. Bulls and Cows

You are playing the Bulls and Cows game with your friend.

You write down a secret number and ask your friend to guess what the number is. 
When your friend makes a guess, you provide a hint with the following info:

The number of "bulls", which are digits in the guess that are in the correct position.
The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. 
Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.

The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. 
Note that both secret and guess may contain duplicate digits.

 

Example 1:

Input: secret = "1807", guess = "7810"
Output: "1A3B"
Explanation: Bulls are connected with a '|' and cows are underlined:
"1807"
  |
"7810"

Example 2:

Input: secret = "1123", guess = "0111"
Output: "1A1B"
Explanation: Bulls are connected with a '|' and cows are underlined:
"1123"        "1123"
  |      or     |
"0111"        "0111"
Note that only one of the two unmatched 1s is counted as a cow since the non-bull digits can only be 
rearranged to allow one 1 to be a bull.
 

Constraints:

1 <= secret.length, guess.length <= 1000
secret.length == guess.length
secret and guess consist of digits only.

*/