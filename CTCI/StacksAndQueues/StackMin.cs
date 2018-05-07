using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class StackMin
    {
        //public static void Main(string[] args)
        //{
        //    CTCIVersion();
        //}

        public static void CTCIVersion()
        {
            var minStack = new StackWithMin();

            minStack.push(10);
            minStack.push(6);
            minStack.push(4);
            minStack.push(8);
            minStack.push(3);
            minStack.push(8);

            Console.WriteLine(minStack.min());
            Console.ReadLine();

        }



        public class StackWithMin : Stack<int>
        {
            Stack<int> s2;
            public StackWithMin()
            {
                s2 = new Stack<int>();
            }

            public void push(int val)
            {
                if (val < min())
                {
                    s2.Push(val);
                }
                base.Push(val);
            }

            public int pop()
            {
                var val = base.Pop();
                if (val == min())
                {
                    s2.Pop();
                }
                return val;
            }

            public int min()
            {
                if (s2.Count == 0)
                {
                    return int.MaxValue;
                }
                return s2.Peek();
            }

        }

    }
}
