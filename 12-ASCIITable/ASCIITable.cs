﻿using System;

    class ASCIITable
    {
        static void Main()
        {
            for (int i = 33; i <=126; i++)
            {
                Console.Write(Convert.ToChar(i));
            }
            Console.ReadLine();
        }
    }

