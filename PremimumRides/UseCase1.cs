using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFare
{
    public class UseCase1
    {
        public float invoiceGenerator(float farePerKM)
        {
            Console.WriteLine("Enter Distance");
            float distance = float.Parse(Console.ReadLine());
            if(distance<=0)
            {
                Console.WriteLine("Enter distance greater than 0");
                invoiceGenerator(farePerKM);
            }
            if(farePerKM==10)
            {
                float normal=farePerKM* distance;
                if (normal < 5)
                {
                    Console.WriteLine("Ride fare must be greater than Rs 5");
                    invoiceGenerator(farePerKM);
                }
            }
            if (farePerKM == 15)
            {
                float premium = farePerKM * distance;
                if (premium < 20)
                {
                    Console.WriteLine("Ride fare must be greater than Rs 20");
                    invoiceGenerator(farePerKM);
                }
            }
            return farePerKM * distance;

        }
    }
}
