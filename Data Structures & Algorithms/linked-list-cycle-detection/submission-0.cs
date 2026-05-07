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
    public bool HasCycle(ListNode head) {
        if (head == null) {
            return false;
        }

        var seen = new HashSet<ListNode>();
        var current = head;
        while (head.next != null) {
            if (seen.Contains(head.next)) {
                return true;
            }
            seen.Add(head);
            head = head.next;
        }
        return false;
    }
}
