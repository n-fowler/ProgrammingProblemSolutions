using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class ReverseLinkedListProblem
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            ListNode node = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return node;
        }
    }
}
