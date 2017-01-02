using System;

    class ZeroVariables
    {
        static void Main()
        {
            int? intVar = null;
            double? doubleVar = null;
            Console.WriteLine("{0}\n{1}\n", intVar, doubleVar);
            Console.WriteLine("{0}\n{1}\n", intVar + 42, doubleVar - 17.63);
            intVar = 42;
            doubleVar = -17.63d;
            Console.WriteLine(intVar);
            Console.WriteLine(doubleVar);
            
        }
    }

