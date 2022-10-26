using System;

public class D_10_02_70_Climbing_Stairs
{
    public int ClimbStairs(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        int[] FibArray = new int[n + 2];
        FibArray[0] = 0;
        FibArray[1] = 1;
        int Result = 0;
        for (int i = 2; i <= n + 1; i++)
        {
            FibArray[i] = FibArray[i - 1] + FibArray[i - 2];
            Result = FibArray[i];

        }
        return Result;
    }

    /*
    public int ClimbStairs(int n)
    {
        if (n < 4) { return n; }

        int x1 = 2, x2 = 3, temp;
        for (int i = 4; i <= n; i++)
        {
            temp = x1 + x2;
            x1 = x2;
            x2 = temp;
        }

        return x2;
    }
    */

    /*
    public int ClimbStairs(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        int prev1 = 1;
        int prev2 = 2;

        for (int i = 3; i <= n; i++)
        {
            int newValue = prev1 + prev2;
            prev1 = prev2;
            prev2 = newValue;
        }
        return prev2;
    }
    */



    /*
     // DO NOT WRITE THE CODE BELOW.
    // LEETCODE DOESN'T ACCEPT IT.
    // SAME RESULT BUT TIME LIMITE EXCEEDED
     
    static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Fib(n - 1) + Fib(n - 2);
    }
    public int ClimbStairs(int s)
    {
        return Fib(s + 1);
    }
    */

}


/*
70. Climbing Stairs

You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?



Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step

*/

