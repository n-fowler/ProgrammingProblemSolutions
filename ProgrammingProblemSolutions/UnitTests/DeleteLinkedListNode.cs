using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;
using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class DeleteLinkedListNode
    {
        [TestCase()]
        public void DeleteLinkedListTest()
        {
            ListNode nodeOne = new ListNode(4);
            ListNode nodeTwo = new ListNode(5);
            ListNode nodeThree = new ListNode(1);
            ListNode nodeFour = new ListNode(9);
            nodeOne.next = nodeTwo;
            nodeTwo.next = nodeThree;
            nodeThree.next = nodeFour;
            new DeleteLinkedListNodeProblem().DeleteNode(nodeTwo);
        }
    }
}
