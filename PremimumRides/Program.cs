using System;

namespace CalculateFare
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase1 obj = new UseCase1();
            float totalFare=0, rideFare=0,avgFarePerRide=0,premiumFare=15,normalFare=10;
            int totalRides = 0, ch;
            do
            {
                Console.WriteLine("Premimum Ride : 1");
                Console.WriteLine("Normal Ride: 2");
                Console.WriteLine("Work Done Exit : 3");
                Console.WriteLine("-----------------");
                Console.WriteLine("Enter your choice");
                ch= int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        totalRides++;
                        rideFare = obj.invoiceGenerator(premiumFare);
                        totalFare = totalFare + rideFare;
                        Console.WriteLine("Ride Fare : " + rideFare);
                        Console.WriteLine("-----------");
                        break;
                    case 2:
                        totalRides++;
                        rideFare = obj.invoiceGenerator(normalFare);
                        totalFare = totalFare + rideFare;
                        Console.WriteLine("Ride Fare : " + rideFare);
                        Console.WriteLine("-----------");
                        break;
                    case 3:
                        Console.WriteLine("Thanks for taking ride with us, Have a nice day");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;

                }
            } while (ch != 3);
            Console.WriteLine("----------------");
            Console.WriteLine("Total Rides :" + totalRides);
            Console.WriteLine("Total Fare : " + totalFare);
            avgFarePerRide = totalFare / totalRides;
            Console.WriteLine("Average Fare Per Ride : " + avgFarePerRide);
        }
    }
}
