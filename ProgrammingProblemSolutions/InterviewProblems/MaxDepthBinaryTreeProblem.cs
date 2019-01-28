using ProgrammingProblemSolutions.Utility;
using System;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class MaxDepthBinaryTreeProblem
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftMaxDepth = MaxDepth(root.left);
            int rightMaxDepth = MaxDepth(root.right);
            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
        }
    }
}
