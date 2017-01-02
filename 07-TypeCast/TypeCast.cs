using System;

    class TypeCast
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World !";
            object firstSecond = first + " " + second;
            string thirth = (string)firstSecond;
            Console.WriteLine(thirth);
        }
    }
