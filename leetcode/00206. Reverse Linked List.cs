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
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
        {
            return head;
        }

        var prev = head;
        var node = head.next;

        while (node != null)
        {
            var nextNode = node.next;

            prev.next = nextNode;
            node.next = head;
            head = node;

            node = nextNode;
        }

        return head;
    }
}