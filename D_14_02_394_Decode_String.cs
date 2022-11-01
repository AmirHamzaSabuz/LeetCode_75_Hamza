using System.Collections;
using System.Text;

internal class D_14_02_394_Decode_String 
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        string result1 = DecodeString("3[a]2[bc]");
        Console.WriteLine("result1 = " + result1);
        Console.WriteLine();

        //string result2 = DecodeString("3[a2[c]]");
        //Console.WriteLine("result2 = " + result2);
        //Console.WriteLine();

        //string result3 = DecodeString("2[abc]3[cd]ef");
        //Console.WriteLine("result3 = " + result3);

        Console.ReadKey();

    }

    /* //Explanation
    public static string DecodeString(string s)
    {
        var countStack = new Stack<int>();
        var strStack = new Stack<string>();

        var sb = new StringBuilder();
        var num = 0;
        foreach (var ch in s)
        {
            Console.WriteLine();
            Console.WriteLine("ch  = " + ch);
            Console.WriteLine("if (char.IsDigit(ch))");
            if (char.IsDigit(ch))
            {
                Console.WriteLine();
                Console.WriteLine("char.IsDigit(ch) true. In if block");
                Console.WriteLine();

                Console.WriteLine("num = " + num + ", ch = " + ch + ", ch - '0' = " + (ch - '0'));
                Console.WriteLine("num = num * 10 + ch - '0';");
                num = num * 10 + ch - '0';
                Console.WriteLine("num = " + num);
                Console.WriteLine("end if block");
                Console.WriteLine();
            }
            else if (ch == '[')
            {
                Console.WriteLine();
                Console.WriteLine("(ch == '[') true. In else if block");
                Console.WriteLine();

                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("strStack.Push(sb.ToString());");
                strStack.Push(sb.ToString());

                Console.WriteLine();

                Console.WriteLine("num = " + num);
                Console.WriteLine("countStack.Push(num);");
                countStack.Push(num);

                Console.WriteLine();

                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("sb.Clear();");
                sb.Clear();
                Console.WriteLine("sb.ToString() = " + sb.ToString());

                Console.WriteLine();

                Console.WriteLine("num = " + num);
                Console.WriteLine("num = 0;");
                num = 0;
                Console.WriteLine("num = " + num);
                Console.WriteLine("end else if(ch == '[') block");
                Console.WriteLine();
            }
            else if (ch == ']')
            {
                Console.WriteLine();
                Console.WriteLine("(ch == ']') true. In else if block");
                Console.WriteLine();

                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("var str = sb.ToString();");
                var str = sb.ToString();

                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("sb.Clear();");
                sb.Clear();
                Console.WriteLine("sb.ToString() = " + sb.ToString());

                Console.WriteLine("sb.Append(strStack.Pop());");
                sb.Append(strStack.Pop());
                Console.WriteLine("sb.ToString() = " + sb.ToString());

                Console.WriteLine("countStack.Peek() = " + countStack.Peek());
                var count = countStack.Pop();
                Console.WriteLine("var count = countStack.Pop();");
                Console.WriteLine("count = " + count);
                Console.WriteLine();

                Console.WriteLine("for (int i = 0; i < count; i++) ");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("i = " + i + ", str = " + str);
                    sb.Append(str);
                    Console.WriteLine(" sb.Append(str); ");                   
                    Console.WriteLine("sb.ToString() = " + sb.ToString());
                    Console.WriteLine();
                }
                Console.WriteLine("end else if (ch == ']')");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("(char.IsDigit(ch)) false, (ch == '[') false, (ch == ']') false.  in else block");
                Console.WriteLine("ch = " + ch);
                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("sb.Append(ch);");
                sb.Append(ch);
                Console.WriteLine("sb.ToString() = " + sb.ToString());
                Console.WriteLine("end else block");
            }
        }
        Console.WriteLine();
        Console.WriteLine("end foreach loop");
        Console.WriteLine("return sb.ToString();");
        Console.WriteLine("sb.ToString() = " + sb.ToString());
        return sb.ToString();
    }
    */


    public static string DecodeString(string s)
    {
        var countStack = new Stack<int>();
        var strStack = new Stack<string>();

        var sb = new StringBuilder();
        var num = 0;
        foreach (var ch in s)
        {
            if (char.IsDigit(ch))
                num = num * 10 + ch - '0';
            else if (ch == '[')
            {
                strStack.Push(sb.ToString());
                countStack.Push(num);
                sb.Clear();
                num = 0;
            }
            else if (ch == ']')
            {
                var str = sb.ToString();
                sb.Clear();
                sb.Append(strStack.Pop());

                var count = countStack.Pop();
                for (int i = 0; i < count; i++)
                    sb.Append(str);
            }
            else
                sb.Append(ch);
        }

        return sb.ToString();
    }

}


/*
394. Decode String

Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], 
where the encoded_string inside the square brackets is being repeated exactly k times. 
Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, 
square brackets are well-formed, etc. 
Furthermore, you may assume that the original data does not contain any digits and 
that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

The test cases are generated so that the length of the output will never exceed 105.

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
 */




// Learning Stack

/*
Stack st = new Stack();
st.Push(1);
st.Push(2);
st.Push(3);

st.Pop();

foreach (Object obj in st)
{
Console.WriteLine(obj);
}
*/

/*
Stack myStack = new Stack();

myStack.Push("Hello");
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(3.5);
myStack.Push(null);
myStack.Push(4);
myStack.Push("Top of Stack. Last in First out");


foreach (var stackItem in myStack)
{ 
    Console.WriteLine(stackItem);
}
*/

/*
Stack myStack = new Stack();

myStack.Push("Hello");
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(3.5);
myStack.Push(null);
myStack.Push(4);
myStack.Push("Top of Stack. Last in First out");

Console.WriteLine("The Peak of stack is " + myStack.Peek()); // Top of Stack. Last in First out
*/

/*
Stack myStack = new Stack();

myStack.Push("Hello");
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(3.5);
myStack.Push(null);
myStack.Push(4);
myStack.Push("Top of Stack. Last in First out");

Console.WriteLine("line 96. Stack Length is " + myStack.Count); // 8
myStack.Pop(); // removes "Top of Stack. Last in First out"
Console.WriteLine("line 98. Stack Length is " + myStack.Count); // 7

Console.WriteLine("The Peak of stack is " + myStack.Peek()); // 4

Console.WriteLine("My Stack contains 3. True or False? " + myStack.Contains(3));
*/




// Learning StringBuilder

/*
string[] animals = { "Cow", "Goat", "angry dog" };
StringBuilder builder = new StringBuilder();
//appending
builder.Append("a fox jumped over a ");
builder.Append("lazy dog");
//append line can append a line ending
builder.AppendLine();
//appendjoin can itrate over a set of values
builder.Append("he also jumped on ");
builder.AppendJoin(",", animals);
//can modify the content by 
builder.Replace("fox ", "cat ");
//convert to string
builder.AppendLine();
builder.Append("the angy dog chased him for a long time but the cat excaped");
Console.WriteLine(builder.ToString());
*/

/*
string[] animals = { "Cow", "Goat", "angry dog" };
StringBuilder builder = new StringBuilder();
//appending
builder.Append("a fox jumped over a ");
builder.Append("lazy dog");
Console.WriteLine(builder.ToString());

builder.Clear();
Console.WriteLine(builder.ToString());
*/