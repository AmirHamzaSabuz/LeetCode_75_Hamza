public class D_10_01_509_Fibonacci_Number 
{
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        int[] FibArray = new int[n + 1];
        FibArray[0] = 0;
        FibArray[1] = 1;
        int Result = 0;
        for (int i = 2; i <= n; i++)
        {
            FibArray[i] = FibArray[i - 1] + FibArray[i - 2];
            Result = FibArray[i];

        }
        return Result;
    }
    /*
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        int[] FibArray = new int[n];
        FibArray[0] = 0;
        FibArray[1] = 1;
        int Result1 = 1;
        int Result2 = 0;
        for (int i = 2; i < n; i++)
        {
            FibArray[i] = FibArray[i - 1] + FibArray[i - 2];
            Result1 = FibArray[i];
            Result2 = FibArray[i - 1];

        }
        return Result1 + Result2;
    }
    */

    /*
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        var prev1 = 0;
        var prev2 = 1;
        for (int i = 2; i < n; i++)
        {
            var temp = prev1 + prev2;
            prev1 = prev2;
            prev2 = temp;
        }

        return prev1 + prev2;
    }
    */

    /*
    public int Fib(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int result = Fib(n - 1) + Fib(n - 2);
        return result;

    }
    */

}

