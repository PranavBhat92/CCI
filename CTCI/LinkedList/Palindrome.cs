using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            //MyVersion();
            //CTCIVersion1();
            //CTCIVersion2();
            CTCIVersion3();
        }


        public static void MyVersion()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 2 };
            A.Next.Next.Next = new LinkedListNode { Data = 1 };

            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var palindrome = isPalindrome(A);

            Console.WriteLine("Is the list Palindrome : " + palindrome);
            Console.ReadLine();
        }

        public static bool isPalindrome(LinkedListNode N)
        {
            var runner = N;
            var stack = new Stack<LinkedListNode>();

            while (runner != null)
            {
                stack.Push(runner);
                runner = runner.Next;
            }

            runner = N;

            while (runner != null)
            {
                var temp = stack.Pop();

                if (runner.Data != temp.Data)
                {
                    return false;
                }
                runner = runner.Next;
            }

            return true;
        }

        public static void CTCIVersion1()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 2 };
            A.Next.Next.Next = new LinkedListNode { Data = 1 };

            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var palindrome = isPalindromev1(A);

            Console.WriteLine("Is the list Palindrome : " + palindrome);
            Console.ReadLine();
        }


        public static bool isPalindromev1(LinkedListNode N)
        {
            var reverse = Reverse(N);
            return IsEqual(N, reverse);
        }


        public static LinkedListNode Reverse(LinkedListNode node)
        {
            LinkedListNode reverse = null;

            while (node != null)
            {
                var temp = new LinkedListNode
                {
                    Data = node.Data
                };

                temp.Next = reverse;
                reverse = temp;
                node = node.Next;
            }
            return reverse;
        }

        public static bool IsEqual(LinkedListNode one,LinkedListNode two)
        {
            while (one != null && two != null)
            {
                if (one.Data != two.Data)
                {
                    return false;
                }

                one = one.Next;
                two = two.Next;
            }

            return true;
        }

        public static void CTCIVersion2()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 2 };
            A.Next.Next.Next = new LinkedListNode { Data = 1 };

            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var palindrome = isPalindromev2(A);

            Console.WriteLine("Is the list Palindrome : " + palindrome);
            Console.ReadLine();
        }

        public static bool isPalindromev2(LinkedListNode N)
        {
            var fast = N;
            var slow = N;
            var stack = new Stack<LinkedListNode>();


            while (fast != null && fast.Next != null)
            {
                stack.Push(slow);
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast != null)
            {
                slow = slow.Next;
            }

            while (slow != null)
            {
                var temp = stack.Pop();

                if (temp.Data != slow.Data)
                {
                    return false;
                }

                slow = slow.Next;
            }

            return true;

        }

        public static void CTCIVersion3()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 2 };
            A.Next.Next.Next = new LinkedListNode { Data = 1 };

            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            
            var palindrome = isPalindromev3(A);

            Console.WriteLine("Is the list Palindrome : " + palindrome);
            Console.ReadLine();
        }

        public static int lengthOfList(LinkedListNode node)
        {
            var size = 0;
            while (node != null)
            {
                size++;
                node = node.Next;
            }
            return size;
        }

        public class Result
        {
            public LinkedListNode node;
            public bool result;

            public Result(LinkedListNode node, bool result)
            {
                this.node = node;
                this.result = result;
            }
        }


        public static bool isPalindromev3(LinkedListNode node)
        {
            int length = lengthOfList(node);
            Result p = isPalindromevRecurse(node, length);
            return p.result;
        }

        public static Result isPalindromevRecurse(LinkedListNode node,int length)
        {
            if (node == null || length <= 0)
            {
                return new Result(node,true);
            }
            else if (length == 1)
            {
                return new Result(node.Next,true);
            }

            Result res = isPalindromevRecurse(node.Next, length - 2);

            if (!res.result || res.node == null)
            {
                return res;
            }

            res.result = (node.Data == res.node.Data);
            res.node = res.node.Next;
            return res;

        }

    }
}

