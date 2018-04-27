using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Intersection
    {
        //public static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}


        public static void MyVersion()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 3 };
            A.Next.Next.Next = new LinkedListNode { Data = 4 };


            LinkedListNode B = new LinkedListNode { Data = 1 };
            B.Next = new LinkedListNode { Data = 2 };
            B.Next.Next = A.Next.Next;
            B.Next.Next.Next = A.Next.Next.Next;
            //B.Next.Next = new LinkedListNode { Data = 3 };
            //B.Next.Next.Next = new LinkedListNode { Data = 4 };

            Console.WriteLine("************************Node 1***************************************");
            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine("************************Node 2***************************************");
            temp = B;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            
            var intersecting = isIntersecting(A,B);

            Console.WriteLine("The lists are intersecting? " + intersecting);
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

        public static bool isIntersecting(LinkedListNode A,LinkedListNode B)
        {
            var lengthA = lengthOfList(A);
            var lengthB = lengthOfList(B);


            if (lengthA != lengthB)
            {
                if (lengthA > lengthB)
                {
                    var count = lengthA - lengthB;
                    while (count > 0)
                    {
                        A = A.Next;
                        count--;
                    }
                }
                else
                {
                    var count = lengthB - lengthA;
                    while (count > 0)
                    {
                        B = B.Next;
                        count--;
                    }
                }
            }

            var runnerA = A;
            var runnerB = B;

            while (runnerA.Next != null && runnerB.Next != null)
            {
                runnerA = runnerA.Next;
                runnerB = runnerB.Next;
            }

            if (runnerA != runnerB)
            {
                return false;
            }

            runnerA = A;
            runnerB = B;

            while (runnerA != null && runnerB != null)
            {
                if (runnerA == runnerB)
                {
                    break;
                }

                runnerA = runnerA.Next;
                runnerB = runnerB.Next;
            }

            if (runnerA == null || runnerB == null)
            {
                return false;
            }

            Console.WriteLine("Intersecting Node = " + runnerA.Data);
            return true;

        }

        public static void CTCIVersion()
        {
            LinkedListNode A = new LinkedListNode { Data = 1 };
            A.Next = new LinkedListNode { Data = 2 };
            A.Next.Next = new LinkedListNode { Data = 3 };
            A.Next.Next.Next = new LinkedListNode { Data = 4 };


            LinkedListNode B = new LinkedListNode { Data = 1 };
            B.Next = new LinkedListNode { Data = 2 };
            B.Next.Next = A.Next.Next;
            B.Next.Next.Next = A.Next.Next.Next;
            //B.Next.Next = new LinkedListNode { Data = 3 };
            //B.Next.Next.Next = new LinkedListNode { Data = 4 };

            Console.WriteLine("************************Node 1***************************************");
            var temp = A;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine("************************Node 2***************************************");
            temp = B;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var intersecting = FindIntersection(A, B);

            if (intersecting != null)
            {
                Console.WriteLine("The lists are intersecting at node : " + intersecting.Data);
            }
            else
            {
                Console.WriteLine("The lists are not intersecting");
            }
            
            Console.ReadLine();
        }

        public static LinkedListNode FindIntersection(LinkedListNode A, LinkedListNode B)
        {
            if (A == null || B == null)
            {
                return null;
            }

            var R1 = getTailAndSize(A);
            var R2 = getTailAndSize(B);

            if (R1.tail != R2.tail)
            {
                return null;
            }

            var shorter = (R1.size < R2.size) ? A : B;
            var longer = (R1.size < R2.size) ? B : A;

            longer = getKthNode(longer, Math.Abs(R1.size-R2.size));

            while (shorter != longer)
            {
                shorter = shorter.Next;
                longer = longer.Next;
            }

            return longer;
        }

        public class Result
        {
            public LinkedListNode tail;
            public int size;

            public Result(LinkedListNode tail,int size)
            {
                this.tail = tail;
                this.size = size;
            }
        }


        public static Result getTailAndSize(LinkedListNode node)
        {
            if (node == null)
            {
                return null;
            }

            var count = 1;
            while (node != null)
            {
                node = node.Next;
                count++;
            }

            return new Result(node,count);
        }


        public static LinkedListNode getKthNode(LinkedListNode head, int count)
        {
            var node = head;
            while (count > 0 && node != null)
            {
                node = node.Next;
                count--;
            }
            return node;

        }

    }
}
