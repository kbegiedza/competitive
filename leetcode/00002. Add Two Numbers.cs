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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var first = l1;
        var second = l2;

        var firstSum = first.val + second.val;

        first = first.next;
        second = second.next;

        var head = new ListNode(firstSum % 10);
        var carryOver = firstSum / 10;

        var node = head;

        while (first != null && second != null)
        {
            var sum = first.val + second.val + carryOver;

            node.next = new ListNode(sum %10);

            carryOver = sum / 10;

            first = first.next;
            second = second.next;

            node = node.next;
        }

        while (first != null)
        {
            var sum = first.val + carryOver;

            node.next = new ListNode(sum %10);

            carryOver = sum / 10;

            first = first.next;

            node = node.next;
        }

        while (second != null)
        {
            var sum = second.val + carryOver;

            node.next = new ListNode(sum %10);

            carryOver = sum / 10;

            second = second.next;

            node = node.next;
        }

        if (carryOver > 0)
        {
            node.next = new ListNode(carryOver);
        }

        return head;
    }
}