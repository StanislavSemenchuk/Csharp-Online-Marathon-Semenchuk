using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    public class CircleOfChildren
    {
        private List<string> children;
        public CircleOfChildren(IEnumerable<string> children)
        {
            this.children = children.ToList();
        }
        public IEnumerable GetChildrenInOrder(int syllables, int childrenToLeave = 0)
        {
            int childrenToKick = children.Count;
            if (syllables <= 0)
            {
                yield break;
            }
            if (childrenToLeave != 0)
            {
                childrenToKick = childrenToLeave < children.Count ? childrenToLeave : children.Count;
            }

            int iter = 0;
            while (childrenToKick > 0)
            {
                iter = (iter + syllables - 1) % children.Count;
                yield return children[iter];
                children.RemoveAt(iter);
                childrenToKick--;
            }
        }
    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren circle, int syllables, int ch = 0)
        {
            foreach (var c in circle.GetChildrenInOrder(syllables, ch))
            {
                Console.Write(c + " ");
            }
        }
    }
}
