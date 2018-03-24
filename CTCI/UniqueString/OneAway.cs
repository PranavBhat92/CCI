using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class OneAway
    {
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        #region Not Wroking
        public static void MyVersion()
        {
            /*
                Input: str1 = "pale", str2 = "ple"                
                Output: true

                Input: str1 = "pale", str2 = "bae"
                Output: false
            */
            var str1 = "pale".ToLower();
            var str2 = "bae".ToLower();
            int c1 = 0;
            int c2 = 0;
            bool result = false;

            if (str1.Length == (str2.Length + 1) || str1.Length == (str2.Length - 1))
            {
                foreach (var item in str1)
                {
                    c1 += item;
                }

                foreach (var item in str2)
                {
                    c2 += item;
                }
                if (c1 > c2)
                {
                    result = ((c1 - c2) >= 97 && (c1 - c2) <= 122) ? true : false;
                }
                else
                {
                    result = ((c2 - c1) >= 97 && (c2 - c1) <= 122) ? true : false;
                }
            }
            else if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    c1 += str1[i];
                    c2 += str2[i];
                }

                if (((c1 > c2) && (c1-c2) >= 0 && (c1-c2) < 26) || ((c2>c1) && (c2-c1) >= 0 && (c2-c1) < 26))
                {
                    result = true;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        public static void CTCIVersion()
        {
            var str1 = "pale".ToLower();
            var str2 = "bae".ToLower();
            var oneAway = false;


            if (str1.Length - 1 == str2.Length)
            {
                int index1 = 0,index2 = 0;

                while (index1 < str1.Length && index2 < str2.Length)
                {
                    if (str1[index1] != str2[index2])
                    {
                        if (index1 != index2)
                        {
                            oneAway = false;
                            break;
                        }
                        oneAway = true;
                        index1++;
                    }
                    else
                    {
                        index1++;
                        index2++;
                    }
                }


            }
            else if (str1.Length + 1 == str2.Length)
            {
                int index1 = 0, index2 = 0;

                while (index1 < str1.Length && index2 < str2.Length)
                {
                    if (str1[index1] != str2[index2])
                    {
                        if (index1 != index2)
                        {
                            oneAway = false;
                            break;
                        }
                        oneAway = true;
                        index2++;
                    }
                    else
                    {
                        index1++;
                        index2++;
                    }
                }
            }
            else if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        if (oneAway)
                        {
                            oneAway = false;
                            break;
                        }

                        oneAway = true;
                    }
                }
            }

            if (oneAway)
            {
                Console.WriteLine("Yes, One Away");
            }
            else
            {
                Console.WriteLine("Not One Away");
            }

            Console.ReadLine();
        }
    }
}
