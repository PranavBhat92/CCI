using System;

namespace UniqueString
{
    class UniqueString
    {
        /// <summary>
        /// Program to find whether the given string has all unique characters
        /// </summary>
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        // Here there is no questions asked and no assumptions.
        // The runtime would be O(n^2)
        public static void MyVersion()
        {
            var str = "Qwerty";
            //var str = "Pranav";
            var len = str.Length;
            var flag = true;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] == str[j])
                    {
                        flag = false;
                    }
                }
            }

            Console.WriteLine(flag);
            Console.ReadLine();
        }


        // Here the assumption is that characters of the string will be ASCII
        // Time Complexity is O(n)
        public static void CTCIVersion()
        {
            var str = "Qwerty";
            //var str = "Pranav";
            var flag = true;

            if (str.Length > 128)
            {
                flag = false;
            }

            var char_set = new bool[128];

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {
                    flag = false;
                }

                char_set[val] = true;
            }
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
