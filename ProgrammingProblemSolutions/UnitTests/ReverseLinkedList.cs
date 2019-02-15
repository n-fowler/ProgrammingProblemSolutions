using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;
using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ReverseLinkedList
    {
        [TestCase()]
        public void ReverseLinkedListTest()
        {
            ListNode nodeOne = new ListNode(1);
            ListNode nodeTwo = new ListNode(2);
            ListNode nodeThree = new ListNode(3);
            ListNode nodeFour = new ListNode(4);
            ListNode nodeFive = new ListNode(5);
            nodeOne.next = nodeTwo;
            nodeTwo.next = nodeThree;
            nodeThree.next = nodeFour;
            nodeFour.next = nodeFive;

            ListNode actualHead = new ReverseLinkedListProblem().ReverseList(nodeOne);

            Assert.AreEqual(nodeFive, actualHead);
            Assert.AreEqual(nodeFour, nodeFive.next);
            Assert.AreEqual(nodeThree, nodeFour.next);
            Assert.AreEqual(nodeTwo, nodeThree.next);
            Assert.AreEqual(nodeOne, nodeTwo.next);
            Assert.IsNull(nodeOne.next);
        }
    }
}
