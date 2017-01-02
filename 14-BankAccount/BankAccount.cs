using System;

 class BankAccount
    {
        static void Main()
        {
            string firstName = "";
            string secondName = "";
            string familyName = "";            
            decimal balance = 0.0m;
            string bankName = "";
            string BIC = "";
            string IBAN = "";
            string[] creditCards = new string[3];
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n", firstName.GetTypeCode(), 
            secondName.GetTypeCode(),familyName.GetTypeCode(),balance.GetTypeCode(),bankName.GetTypeCode(),
            BIC.GetTypeCode(),IBAN.GetTypeCode(), creditCards.GetType());




           
        }
    }

