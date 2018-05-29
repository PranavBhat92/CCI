using System;

namespace StringsAndArrays
{
    class StringRotation
    {
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        public static void CTCIVersion()
        {
            var s1 = "waterbottle".ToLower();
            var s2 = "erbottlewat".ToLower();
            var result = false;


            if (s1.Length == s2.Length)
            {
                var temp = s1 + s1; // Because, s2 will always be a substring of s1s1 if it is rotated

                if (temp.Contains(s2))
                {
                    result = true;
                }
            }

            if (result)
            {
                Console.WriteLine("Strings ARE rotation of each other");
            }
            else
            {
                Console.WriteLine("Strings are NOT rotation of each other");
            }

            Console.ReadLine();
        }
    }
}
