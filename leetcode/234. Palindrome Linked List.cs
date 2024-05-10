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
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var forward = head;
        var node = head;

        while (forward != null && forward.next != null)
        {
            forward = forward.next.next;
            node = node.next;
        }

        var prev = default(ListNode);

        while (node != null)
        {
            var tmp = node.next;
            node.next = prev;
            prev = node;
            node = tmp;
        }

        var left = head;
        var right = prev;

        while (right != null)
        {
            if (left.val != right.val)
            {
                return false;
            }

            left = left.next;
            right = right.next;
        }

        return true;
    }
}