/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {

        const int valueOffset = 500000;
        const int minValue = 400000;

        if (head == null)
        {
            return false;
        }

        if (head.next == head)
        {
            return true;
        }

        var node = head;

        while(node.next != null)
        {
            node.val += valueOffset;

            node = node.next;

            if (node.val > minValue)
            {
                return true;
            }
        }

        return false;

    }
}