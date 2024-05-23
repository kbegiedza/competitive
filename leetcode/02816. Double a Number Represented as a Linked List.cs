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
    public ListNode DoubleIt(ListNode head) {

        var lastNode = head;
        var node = head.next;

        while (node != null)
        {
            var nextNode = node.next;
            lastNode.next = nextNode;

            node.next = head;
            head = node;

            node = nextNode;
        }

        var carryOver = 0;

        node = head;
        var prevNode = head;

        while(node != null)
        {
            var sum = node.val + node.val + carryOver;

            if (sum >= 10)
            {
                node.val = sum % 10;

                carryOver = sum / 10;
            }
            else
            {
                node.val = sum;

                carryOver = 0;
            }

            prevNode = node;
            node = node.next;
        }

        if(carryOver != 0)
        {
            prevNode.next = new ListNode(carryOver);
        }

        lastNode = head;
        node = head.next;

        while (node != null)
        {
            var nextNode = node.next;
            lastNode.next = nextNode;

            node.next = head;
            head = node;

            node = nextNode;
        }

        return head;
    }
}