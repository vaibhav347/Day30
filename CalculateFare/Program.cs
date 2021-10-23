using System;

namespace CalculateFare
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase1 obj = new UseCase1();
            int totalFare=obj.invoiceGenerator();
            Console.WriteLine("Total Fare : " + totalFare);
        }
    }
}
