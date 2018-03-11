using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    class Urlify
    {
        static void Main(string[] args)
        {
            MyVersion();
            //CTCIVersion();
        }

        public static void MyVersion()
        {
            /*
                Input: "Mr John Smith      ", 13
                Output: "Mr%20John%20Smith"
            */

            char[] charArr = "Mr John Smith      ".ToCharArray();
            var len = 13;

            for (int i = 13; i > 0; i--)
            {
                if (charArr[i] != ' ')
                {
                    continue;
                }
                else
                {
                    charArr[i] = '%';                    
                }
            }

            Console.WriteLine(charArr);
            Console.ReadLine();

        }

        public static void CTCIVersion()
        {

        }
    }
}
