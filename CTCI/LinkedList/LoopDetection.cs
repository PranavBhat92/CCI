using System;

namespace LinkedList
{
    class LoopDetection
    {
        //public static void Main(string[] args)
        //{
        //   CTCIVersion();
        //}

        public static void CTCIVersion()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 3 };
            A.Next.Next.Next = new LinkedListNode { Data = 4 };
            A.Next.Next.Next.Next = new LinkedListNode { Data = 5 };
            A.Next.Next.Next.Next.Next = new LinkedListNode { Data = 6 };
            A.Next.Next.Next.Next.Next.Next = new LinkedListNode { Data = 7 };
            A.Next.Next.Next.Next.Next.Next.Next = A.Next.Next.Next;

            LinkedListNode result = FindLoopStart(A);

            if (result == null)
            {
                Console.WriteLine("No loops!");
            }
            else
            {
                Console.WriteLine("Loop detected at node = " + result.Data);
            }

            Console.ReadLine();
        }


        public static LinkedListNode FindLoopStart(LinkedListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (fast == null || fast.Next == null)
            {
                return null;
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;

        }




    }
}
