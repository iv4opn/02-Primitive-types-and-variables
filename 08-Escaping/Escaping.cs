using System;

    class Escaping
    {
        static void Main()
        {
            string withQuations = "The \"use\" of quotations causes difficulties.";
            string withoutQuationst = @"The ""use"" of quotations causes difficulties.";
            Console.Write("{0}\n{1}\n", withQuations, withoutQuationst);
        }
    }
