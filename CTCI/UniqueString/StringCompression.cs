using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class StringCompression
    {
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}


        public static void MyVersion()
        {
            /*
                input: "aaaaacccbb"
                output: "a5c3b2"
                
            
                input: "aaaba"
                output: "aaaba" 
            */

            var count = 1;
            var str1 = "aaaba";
            var str2 = "";
            var i = 0;

            for (i = 1; i < str1.Length; i++)
            {
                if (str1[i] == str1[i - 1])
                {
                    count++;
                }
                else
                {
                    str2 += str1[i - 1] + count.ToString();
                    count = 1;
                }
            }

            if (count > 1)
            {
                str2 += str1[i - 1] + count.ToString();
            }
            else
            {
                str2 += str1[i - 1] + "1";
            }

            if (str2.Length > str1.Length)
            {
                Console.WriteLine("Could not compress :" + str1);
            }
            else
            {
                Console.WriteLine("Compression Successful :" + str2);
            }

            Console.ReadLine();

        }

        public static void CTCIVersion()
        {
            var str = "aaaaacccbb";
            StringBuilder compressed = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;

                /* If next character is different than current, append this char to result.*/
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }

            }

            if (compressed.Length < str.Length)
            {
                Console.WriteLine("Compression Successful :" + compressed);
            }
            else
            {
                Console.WriteLine("Could not compress :" + str);
            }

            Console.ReadLine();

        }
    }
}
