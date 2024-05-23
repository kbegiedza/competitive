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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var removalOffset = 0;

        var toRemove = head;
        var tail = head;
        var preToRemove = head;

        while(tail != null)
        {
            if (++removalOffset > n)
            {
                preToRemove = toRemove;
                toRemove = toRemove.next;
            }

            tail = tail.next;
        }

        if (preToRemove == toRemove)
        {
            return toRemove.next;
        }

        preToRemove.next = toRemove.next;

        return head;
    }
}