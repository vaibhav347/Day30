using System;

namespace CalculateFare
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase1 obj = new UseCase1();
            int totalFare = 0, rideFare = 0,ch,totalRides=0, avgFarePerRide=0;
            Console.WriteLine("Total Fare : " + totalFare);
            do
            {
                Console.WriteLine("Do You Want To Take Ride With Us ? : 1");
                Console.WriteLine("Work Done Exit : 2");
                Console.WriteLine("-----------------");
                Console.WriteLine("Enter your choice");
                ch= int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        totalRides++;
                        rideFare = obj.invoiceGenerator();
                        totalFare = totalFare + rideFare;
                        Console.WriteLine("Ride Fare : " + rideFare);
                        Console.WriteLine("-----------");
                        break;
                    case 2:
                        Console.WriteLine("Thanks for taking ride with us, Have a nice day");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;

                }
            } while (ch != 2);
            Console.WriteLine("----------------");
            Console.WriteLine("Total Rides :" + totalRides);
            Console.WriteLine("Total Fare : " + totalFare);
            avgFarePerRide = totalFare / totalRides;
            Console.WriteLine("Average Fare Per Ride : " + avgFarePerRide);
        }
    }
}
