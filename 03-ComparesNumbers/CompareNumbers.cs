﻿using System;

    class CompareNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double precision = 0.000001;
            bool equal=Math.Abs(a-b)<precision;
            Console.WriteLine(equal);
        }
    }

