using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFare
{
    public class UseCase1
    {
        public int invoiceGenerator()
        {
            int farePerKM = 10;
            Console.WriteLine("Enter Distance");
            int distance = int.Parse(Console.ReadLine());
            if(distance<=0)
            {
                Console.WriteLine("Enter distance greater than 0");
                invoiceGenerator();
            }
            return farePerKM * distance;

        }
    }
}
