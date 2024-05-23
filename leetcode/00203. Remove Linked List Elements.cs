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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
        {
            return head;
        }

        var node = head;
        var prevNode = head;

        while (node != null)
        {
            if (node.val == val)
            {
                if(node == head)
                {
                    head = node.next;
                    prevNode = head;
                }
                else
                {
                    prevNode.next = node.next;
                }
            }
            else
            {
                prevNode = node;
            }

            node = node.next;
        }

        return head;
    }
}