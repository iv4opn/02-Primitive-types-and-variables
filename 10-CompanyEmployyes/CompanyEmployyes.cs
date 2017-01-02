using System;

    class CompanyEmployyes
    {
        static void Main()
        {
            string firstName="";
            string famylyName="";
            byte age=0;
            bool isMale=true;
            ulong idNum=0;
            uint uniqueEmployyeNum = 0;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", firstName.GetTypeCode(),
               famylyName.GetTypeCode(), age.GetTypeCode(), isMale.GetTypeCode(),
               idNum.GetTypeCode(), uniqueEmployyeNum.GetTypeCode());
            
        }
    }

