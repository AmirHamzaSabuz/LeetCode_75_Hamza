using System;

public class D_03_01_21_Merge_Two_Sorted_Lists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode(-1);
        var current = head;

        if (list1 == null) return list2;
        if (list2 == null) return list1;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;


        }

        current.next = list1 == null ? list2 : list1;
        return head.next;


    }
}



public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

//public class D_03_01_21_Merge_Two_Sorted_Lists
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        /* a dummy first node to 
//        hang the result on */
//        ListNode dummyNode = new ListNode(0);

//        /* tail points to the 
//        last result node */
//        ListNode tail = dummyNode;
//        while (true)
//        {

//            /* if either list runs out, 
//            use the other list */
//            if (list1 == null)
//            {
//                tail.next = list2;
//                break;
//            }
//            if (list2 == null)
//            {
//                tail.next = list1;
//                break;
//            }

//            /* Compare the data of the two 
//            lists whichever lists' data is 
//            smaller, append it into tail and 
//            advance the head to the next Node 
//            */
//            if (list1.val <= list2.val)
//            {
//                tail.next = list1;
//                list1 = list1.next;
//            }
//            else
//            {
//                tail.next = list2;
//                list2 = list2.next;
//            }

//            /* Advance the tail */
//            tail = tail.next;
//        }
//        return dummyNode.next;

//    }
//}


/*

21. Merge Two Sorted Lists
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 */