using System;

namespace LinkedList
{
    class KthToLast
    {
        //public static void Main(string[] srgs)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        public static void MyVersion()
        {
            var K = 2;   // This is the K
            LinkedListNode node = new LinkedListNode { Data = 10, Next = null, Previous = null };
            node.Next = new LinkedListNode { Data = 20, Next = null, Previous = null };
            node.Next.Next = new LinkedListNode { Data = 30, Next = null, Previous = null };
            node.Next.Next.Next = new LinkedListNode { Data = 40 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 50 };

            var count = 0;
            var item = node;

            while (node!= null)
            {
                if (count != K)
                {
                    count++;
                }
                else
                {
                    item = item.Next;
                }                

                node = node.Next;
            }

            if (node == null && count == K)
            {
                Console.WriteLine(item.Data);
            }
            else
            {
                Console.WriteLine("{0}th Element doesn't exist",K);
            }

            Console.ReadLine();
        }


        public static void CTCIVersion()
        {
            LinkedListNode node = new LinkedListNode { Data = 10, Next = null, Previous = null };
            node.Next = new LinkedListNode { Data = 20, Next = null, Previous = null };
            node.Next.Next = new LinkedListNode { Data = 30, Next = null, Previous = null };
            node.Next.Next.Next = new LinkedListNode { Data = 40 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 50 };


            var k = 2;
            LinkedListNode pl = node;
            LinkedListNode p2 = node;

            for (var i = 0; i < k; i++)
            {
                if (pl != null) // Out of bounds
                pl = pl.Next;
            }

            while (pl != null)
            {
                pl = pl.Next;
                p2 = p2.Next;
            }

            Console.WriteLine(p2.Data);
            Console.ReadLine();
        }

    }
}
