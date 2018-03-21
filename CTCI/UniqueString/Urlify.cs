using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    class Urlify
    {
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        public static void MyVersion()
        {
            /*
                Input: "Mr John Smith    ", 13
                Output: "Mr%20John%20Smith"
            */

            char[] charArr = "Mr John Smith    ".ToCharArray();
            var len = 12;   // Truelength - 1

            var i = charArr.Length - 1;

            while (i >= 0)
            {
                if (charArr[len] != ' ')
                {
                    charArr[i--] = charArr[len];
                }
                else
                {
                    charArr[i--] = '0';
                    charArr[i--] = '2';
                    charArr[i--] = '%';
                }

                len--;
            }

            Console.WriteLine(charArr);
            Console.ReadLine();

        }

        public static void CTCIVersion()
        {
            char[] str = "Mr John Smith    ".ToCharArray();
            var trueLength = 13;
            int spaceCount = 0, index;

            for (var i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;

                }
            }

            index = trueLength + spaceCount * 2;

            if (trueLength < str.Length) str[trueLength] = '\0';

            for (var i = trueLength-1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }


            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
