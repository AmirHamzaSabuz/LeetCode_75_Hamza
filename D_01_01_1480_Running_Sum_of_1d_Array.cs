using System;

public class D_01_01_1480_Running_Sum_of_1d_Array
{
    public int[] RunningSum(int[] nums)
    {
        int[] RunningSumArray = new int[nums.Length];
        int sum = 0;
        for (int i = 0; i < RunningSumArray.Length; i++)
        {
            sum = nums[i] + sum;
            RunningSumArray[i] = sum;
        }
        return RunningSumArray;
    }
}

/*
 1480. Running Sum of 1d Array
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

Example 1:

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
Example 2:

Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
Example 3:

Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]
 */
