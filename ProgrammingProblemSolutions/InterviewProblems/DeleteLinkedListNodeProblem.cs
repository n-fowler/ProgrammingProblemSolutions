using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class DeleteLinkedListNodeProblem
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
