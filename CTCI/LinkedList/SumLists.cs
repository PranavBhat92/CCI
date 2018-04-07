using System;

namespace LinkedList
{
    class SumLists
    {
        public static void Main(string[] srgs)
        {
            //MyVersion();
            MyVersionFollowUp();
            //CTCIVersion();
            //CTCIFollowUp();
        }


        public static void MyVersion()
        {
            /*
                Input: A = (7-> 1 -> 6) B = (5 -> 9 -> 2)
                Output: C = (2 -> 1 -> 9)
             */

            LinkedListNode A = new LinkedListNode { Data = 7 };
            A.Next = new LinkedListNode { Data = 1 };
            A.Next.Next = new LinkedListNode { Data = 6 };

            LinkedListNode B = new LinkedListNode { Data = 5 };
            B.Next = new LinkedListNode { Data = 9 };
            B.Next.Next = new LinkedListNode { Data = 2 };

            LinkedListNode C = null;
            LinkedListNode sum = null;
            var carry = 0;
            // Assuming A and B are of same lengths
            while (A != null)
            {
                if (C == null)
                {
                    C = new LinkedListNode { Data = (A.Data + B.Data) % 10 };
                    carry = (A.Data + B.Data) / 10;
                    sum = C;
                }
                else
                {
                    C.Next = new LinkedListNode { Data = (A.Data + B.Data + carry) % 10 };
                    carry = (A.Data + B.Data + carry) / 10;
                    C = C.Next;
                }

                B = B.Next;
                A = A.Next;
            }

            Console.WriteLine("*****************************Result*****************************");
            var temp = sum;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();
        }


        public static void MyVersionFollowUp()
        {
            /*
                Input: A = (6-> 1 -> 7) B = (2 -> 9 -> 5)
                Output: C = (9 -> 1 -> 2)
             */

            LinkedListNode A = new LinkedListNode { Data = 7 };
            A.Next = new LinkedListNode { Data = 1 };
            A.Next.Next = new LinkedListNode { Data = 6 };

            LinkedListNode B = new LinkedListNode { Data = 5 };
            B.Next = new LinkedListNode { Data = 9 };
            B.Next.Next = new LinkedListNode { Data = 2 };

            var Alength = 0;
            var Blength = 0;

            var temA = A;
            var tempB = B;

            // check length of A and B
            while (temA != null || tempB != null)
            {
                if (temA != null)
                {
                    Alength++;
                    temA = temA.Next;
                }

                if (tempB != null)
                {
                    Blength++;
                    tempB = tempB.Next;
                }
            }

            // Append appropriate number of zeros
            if (Alength > Blength)
            {
                var diff = Alength - Blength;
                var zeroNode = new LinkedListNode { Data = 0 };
                var AStart = zeroNode;

                while (diff > 1)
                {
                    zeroNode.Next = new LinkedListNode { Data = 0 };
                    zeroNode = zeroNode.Next;
                    diff--;
                }

                zeroNode.Next = A;
                A = AStart;
            }
            else if (Blength > Alength)
            {
                var diff = Blength - Alength;
                var zeroNode = new LinkedListNode { Data = 0 };
                var BStart = zeroNode;

                while (diff > 1)
                {
                    zeroNode.Next = new LinkedListNode { Data = 0 };
                    zeroNode = zeroNode.Next;
                    diff--;
                }

                zeroNode.Next = B;
                B = BStart;
            }


            LinkedListNode C = null;
            LinkedListNode sum = null;
            var carry = 0;


            while (A != null)
            {
                if (C == null)
                {
                    C = new LinkedListNode { Data = (A.Data + B.Data) % 10 };
                    carry = (A.Data + B.Data) / 10;
                    sum = C;
                }
                else
                {
                    C.Next = new LinkedListNode { Data = (A.Data + B.Data + carry) % 10 };
                    carry = (A.Data + B.Data + carry) / 10;
                    C = C.Next;
                }

                B = B.Next;
                A = A.Next;
            }


            Console.WriteLine("*****************************Result*****************************");
            var temp = sum;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();

        }



        public static void CTCIVersion()
        {
            LinkedListNode l1 = new LinkedListNode { Data = 7 };
            l1.Next = new LinkedListNode { Data = 1 };
            l1.Next.Next = new LinkedListNode { Data = 6 };

            LinkedListNode l2 = new LinkedListNode { Data = 5 };
            l2.Next = new LinkedListNode { Data = 9 };
            l2.Next.Next = new LinkedListNode { Data = 2 };

            LinkedListNode C = addlists(l1, l2, 0);


            Console.WriteLine("*****************************Result*****************************");
            var temp = C;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();

        }


        public  static LinkedListNode addlists(LinkedListNode l1, LinkedListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0) {
                return null;
            }
            LinkedListNode result = new LinkedListNode();
            int value = carry;
            if (l1 != null)
            {
                value += l1.Data;
            }
            if (l2 != null)
            {
                value += l2.Data;
            }

            result.Data = value % 10; //Second digit of number

            // Recursive
            if (l1 != null || l2 != null)
            {
                LinkedListNode more = addlists(l1 == null ? null : l1.Next, l2 == null ? null : l2.Next, value >= 10 ? 1 : 0);
                result.Next = more;
            }

            return result;
        }


        public static void CTCIFollowUp()
        {
            /*
             **************************************************************************************************************
             Implement this without copying
             **************************************************************************************************************
             */
        }

    }
}
