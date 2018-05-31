using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class SortStacks
    {
        //public static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        public class MyStack
        {
            private Stack<int> stack;
            private Stack<int> temp;

            public MyStack()
            {
                stack = new Stack<int>();
                temp = new Stack<int>();
            }

            public bool IsEmpty()
            {
                return (stack.Count == 0);
            }

            public void Push(int val)
            {
                while (!IsEmpty() && stack.Peek() < val)
                {
                    temp.Push(stack.Pop());
                }

                stack.Push(val);

                while (temp.Count != 0)
                {
                    stack.Push(temp.Pop());
                }
                
            }

            public int Pop() {
                if (!IsEmpty())
                {
                    return stack.Pop();
                }
                else
                {
                    throw new Exception("Stack is Empty");
                }          
            }

            public int Peek() {
                if (!IsEmpty())
                {
                    return stack.Peek();
                }
                else
                {
                    throw new Exception("Stack is Empty");
                }
            }
        }

        public static void MyVersion() {

            var myStack = new MyStack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            while (!myStack.IsEmpty())
            {
                Console.WriteLine("Pop " + myStack.Pop());
            }

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            var val = myStack.Pop();

            Console.WriteLine("Popped " + val);
            Console.WriteLine("Peek " + myStack.Peek());

            Console.ReadLine();            
        }


        public static void CTCIVersion()
        {
            var myStack = new Stack<int>();

            myStack.Push(20);
            myStack.Push(5);
            myStack.Push(15);
            myStack.Push(10);

            sort(myStack);


            while (myStack.Count != 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.ReadLine();
        }


        public static void sort(Stack<int> s)
        {
            var r = new Stack<int>();


            while (s.Count != 0)
            {
                var temp = s.Pop();

                while (r.Count != 0 && r.Peek() > temp)
                {
                    s.Push(r.Pop());
                }
                r.Push(temp);
            }

            while (r.Count != 0)
            {
                s.Push(r.Pop());
            }            
        }

    }
}
