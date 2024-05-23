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
    public ListNode OddEvenList(ListNode head) {
        if (head == null)
        {
            return head;
        }

        var i = 2;
        var node = head.next;
        var lastOddNode = head;
        var lastEvenNode = node;

        while(node != null)
        {
            var isOdd = (i & 1) == 1;

            if (isOdd)
            {
                var nextNode = node.next;
                lastEvenNode.next = nextNode;

                node.next = lastOddNode.next;
                lastOddNode.next = node;

                lastOddNode = node;

                node = nextNode;
            }
            else
            {
                lastEvenNode = node;

                node = node.next;
            }

            ++i;
        }

        return head;
    }
}