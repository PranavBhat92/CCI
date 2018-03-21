using System;
using System.Collections.Generic;

namespace UniqueString
{
    class PalindromePermutaion
    {
        static void Main(string[] args)
        {
            //MyVersion();
            //CTCIVersion1();
            //CTCIVersion2();
            CTCIVersion3();
        }

        public static void MyVersion()
        {
            /*
                Input: "Tact Coa"
                Output: true
            */
            var str = "Tact Coa".ToLower();
            var dict = new Dictionary<char, int>();
            var count = 0;

            foreach (var letter in str)
            {
                if(letter != ' ') {
                    if (dict.ContainsKey(letter)) {
                        dict[letter]++;
                    }
                    else
                    {
                        dict[letter] = 1;
                    }
                }
            }

            foreach (var item in dict.Values)
            {
                if ((item % 2) != 0)
                {
                    count++;
                }
            }

            if (count == 0 || count == 1)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadLine();
        }

        public static void CTCIVersion1()
        {
            var phrase = "Tact Coa".ToLower();
            var table = new int['z'-'a'+1];
            bool foundOdd = false;

            foreach (var c in phrase)
            {
                int x = ('a' <= c && c <= 'z') ? (c - 'a') : -1;
                if (x != -1)
                {
                    table[x]++;
                }
            }
            
            foreach (var count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                    {
                        foundOdd = false;
                        break;
                    }
                    foundOdd = true;
                }
            }

            if (foundOdd)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadLine();

        }

        public static void CTCIVersion2()
        {
            var phrase = "Tact Coa".ToLower();
            int countOdd = 0;
            var table = new int['z'-'a'+1];

            foreach (var c in phrase)
            {
                if (c != -1 && c != ' ')
                {
                    int x = ('a' <= c && c <= 'z') ? (c - 'a') : -1;
                    table[x]++;
                    if (table[x] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                    {
                        countOdd--;
                    }
                }
            }

            if (countOdd <= 1)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            Console.ReadLine();

        }

        public static void CTCIVersion3()
        {
            var phrase = "Tactx Coa".ToLower();
            int bitVector = 0;

            foreach (var c in phrase)
            {
                int x = ('a' <= c && c <= 'z') ? (c - 'a') : -1;
                if (!(x < 0)) {
                    int mask = 1 << x;

                    if ((bitVector & mask) == 0)
                    {
                        bitVector |= mask;
                    }
                    else
                    {
                        bitVector &= ~mask;
                    }
                }

                if (bitVector == 0 || (bitVector & (bitVector - 1)) == 0)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                }

                Console.ReadLine();

            }
        }
    }
}
