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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) {
            return list2;
        }
        if (list2 == null) {
            return list1;
        }

        ListNode head;
        ListNode currentLast;
        if (list1.val < list2.val) {
            head = list1;
            list1 = list1.next;
        }
        else {
            head = list2;
            list2 = list2.next;
        }
        currentLast = head;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                currentLast.next = list1;
                list1 = list1.next;
            }
            else {
                currentLast.next = list2;
                list2 = list2.next;
            }
            currentLast = currentLast.next;
        }
        currentLast.next = (list1 == null) ? list2 : list1;

        return head;
    }
}