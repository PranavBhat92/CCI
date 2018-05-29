using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class QueueViaStacks
    {
        //public static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}


        public class MyQueue<T>
        {
            Stack<T> s1 = new Stack<T>();
            Stack<T> s2 = new Stack<T>();


            public void Enqueue(T val)
            {
                s1.Push(val);
            }

            public T Dequeue()
            {
                while (!(s1.Count == 0))
                {                    
                    s2.Push(s1.Pop());
                }

                var dq = s2.Pop();

                while (!(s2.Count == 0))
                {
                    s1.Push(s2.Pop());
                }

                return dq;
            }

            public T Peek()
            {
                while (!(s1.Count == 0))
                {
                    s2.Push(s1.Pop());
                }

                var dq = s2.Peek();

                while (!(s2.Count == 0))
                {
                    s1.Push(s2.Pop());
                }

                return dq;
            }

        }


        public static void MyVersion() {
            MyQueue<int> myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            Console.WriteLine("Peek " + myQueue.Peek());

            myQueue.Dequeue();

            Console.WriteLine("Peek " + myQueue.Peek());

            Console.ReadLine();
        }

        public class CTCIQueue<T>
        {
            Stack<T> oldest = new Stack<T>();
            Stack<T> newest = new Stack<T>();

            public void Enqueue(T value)
            {
                newest.Push(value);
            }


            public T Dequeue()
            {
                ShifStacks();
                return oldest.Peek();
            }


            public T Peek()
            {
                ShifStacks();
                return oldest.Pop();
            }


            private void ShifStacks()
            {
                if (oldest.Count == 0)
                {
                    while (newest.Count != 0)
                    {
                        oldest.Push(newest.Pop());
                    }
                }
            }

        }

        public static void CTCIVersion()
        {
            CTCIQueue<int> myQueue = new CTCIQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            Console.WriteLine("Peek " + myQueue.Peek());

            myQueue.Dequeue();

            Console.WriteLine("Peek " + myQueue.Peek());

            Console.ReadLine();
        }
    }
}
