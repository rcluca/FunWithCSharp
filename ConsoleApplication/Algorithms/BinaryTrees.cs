using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    class BinaryTrees
    {
        public static bool IsBalanced(Node root)
        {
            int min = 0;
            int max = 0;
            return IsBalancedHelper(root, 0, ref min, ref max);
        }

        private static bool IsBalancedHelper(Node n, int level, ref int min, ref int max)
        {
            if (n == null)
            {
                // Decrease level by 1 to get last non-null node level
                level--;

                if (level > max)
                {
                    // If min hasn't been set yet, set it before changing max
                    if (min == 0)
                        min = max;
                    max = level;
                }
                else if (level < min)
                    min = level;

                // If the height of the subtree is greater than 1, it is not balanced
                if (min != 0 && max - min > 1)
                    return false;
                else
                    return true;
            }
            else
            {
                // If either subtree is not balanced, return false
                if (!IsBalancedHelper(n.Left, level + 1, ref min, ref max) || !IsBalancedHelper(n.Right, level + 1, ref min, ref max))
                    return false;
                else
                    return true;
            }
        }
    }

    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
