using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RemoveLinkedListElements
    {
        [TestCase()]
        public void RemoveLinkedListElementsTest()
        {
            ListNode nodeOne = new ListNode(1);
            ListNode nodeTwo = new ListNode(2);
            ListNode nodeThree = new ListNode(6);
            ListNode nodeFour = new ListNode(3);
            ListNode nodeFive = new ListNode(4);
            ListNode nodeSix = new ListNode(5);
            ListNode nodeSeven = new ListNode(6);
            nodeOne.next = nodeTwo;
            nodeTwo.next = nodeThree;
            nodeThree.next = nodeFour;
            nodeFour.next = nodeFive;
            nodeFive.next = nodeSix;
            nodeSix.next = nodeSeven;
            nodeOne = new RemoveLinkedListElementsProcessor().RemoveElements(nodeOne, 6);
        }
    }
}
