using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RemoveLinkedListElementsProcessor
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head?.next == null)
            {
                return head;
            }

            if (head.next.val == val)
            {
                head.next = head.next.next;
            }

            ListNode node = RemoveElements(head.next, val);
            return node;
        }
    }
}
