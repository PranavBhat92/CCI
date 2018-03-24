using System;
using System.Linq;


namespace StringsAndArrays
{
    class Permutation
    {
        //static void Main(string[] args)
        //{
        //    MyVersion();
        //    //CTCIVersion();
        //}

        /// <summary>
        /// A BruteForce approach
        /// </summary>
        public static void MyVersion() {
            var str1 = "country";
            var str2 = "troncuy";
            var flag = true;


            if (str1.Length != str2.Length)
            {
                flag = false;
            }
            else
            {
                foreach (char c in str2)
                {
                    if (!str1.Contains(c))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            Console.WriteLine(flag);
            Console.ReadLine();
        }

        //Assuming character set is ASCII
        public static void CTCIVersion() {
            var str1 = "country";
            var str2 = "troncuy";
            var flag = true;


            if (str1.Length != str2.Length)
            {
                flag = false;
            }
            else
            {
                var letters = new int[128];

                foreach (char c in str1)
                {
                    letters[c]++;
                }

                for (int i = 0; i < str2.Length; i++)
                {
                    int n = str2[i];
                    letters[n]--;

                    if (letters[n] < 0)
                    {
                        flag = false;
                    }
                }

            }

            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
