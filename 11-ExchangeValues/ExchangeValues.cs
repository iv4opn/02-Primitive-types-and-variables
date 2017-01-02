using System;

    class ExchangeValues
    {
        static void Main()
        {
            byte firstVar = 5;
            byte secondVar = 10;
            byte helpVar = firstVar;
            firstVar = secondVar;
            secondVar = helpVar;
            Console.WriteLine(" First value exchanged with: {0}\n Second value echanged with: {1}\n", firstVar, secondVar);
        }
    }

