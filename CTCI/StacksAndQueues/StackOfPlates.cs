using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class StackOfPlates
    {
        //public static void Main(string[] args)
        //{
        //    CTCIVersion();
        //}

        public class SetOfStacks
        {
            public List<Stack<int>> stacks = new List<Stack<int>>();
            public int thresold;

            public SetOfStacks(int capacity)
            {
                thresold = capacity;
            }

            public Stack<int> getLastStack()
            {
                if (stacks.Count == 0)
                {
                    throw new Exception("Empty Stack");
                }
                return stacks.Last();
            }

            public void Push(int v)
            {
                var last = getLastStack();
                if (last != null && last.Count != thresold)
                {
                    last.Push(v);
                }
                else
                {
                    var stack = new Stack<int>();
                    stack.Push(v);
                    stacks.Add(stack);
                }
            }

            public int Pop()
            {
                var last = getLastStack();
                if (last == null)
                {
                    throw new Exception("Empty Stack");
                }
                var v = last.Pop();
                if (last.Count == 0)
                {
                    stacks.RemoveAt(stacks.Count-1);
                }
                return v;
            }

        }

        public static void CTCIVersion()
        {

        }

    }
}
