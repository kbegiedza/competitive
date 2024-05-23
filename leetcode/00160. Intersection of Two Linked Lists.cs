/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null)
        {
            return null;
        }

        if (headB == null)
        {
            return null;
        }

        if (headA == headB)
        {
            return headA;
        }

        var visited = new HashSet<ListNode>();

        var node = headA;

        while (node != null)
        {
            if (visited.Contains(node))
            {
                return node;
            }

            visited.Add(node);
            node = node.next;
        }

        node = headB;

        while (node != null)
        {
            if (visited.Contains(node))
            {
                return node;
            }

            node = node.next;
        }

        return null;
    }
}