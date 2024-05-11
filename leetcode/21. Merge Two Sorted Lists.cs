/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var first = list1;
        var second = list2;

        if (first == null)
        {
            return second;
        }

        if(second == null)
        {
            return first;
        }

        var head = default(ListNode);

        if (first.val > second.val)
        {
            head = second;
            second = second.next;
        }
        else
        {
            head = first;
            first = first.next;
        }

        var node = head;

        while (first  != null || second != null)
        {
            if (first == null)
            {
                node.next = second;
                second = second.next;
            }
            else if(second == null)
            {
                node.next = first;
                first = first.next;
            }
            else
            {
                if(first.val < second.val)
                {
                    node.next = first;
                    first = first.next;
                }
                else
                {
                    node.next = second;
                    second = second.next;
                }
            }

            node = node.next;
        }

        node.next = null;

        return head;
    }
}