using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //You and a freind are deciding on a trip together
            //You want it to have a city and a beach
            //They want it to have a beach or hiking
            //The current pick is Barcelona, a city with a beach. Will we both be happy with this choice?

            bool beach = true;
            bool hiking = false;
            bool city = true;
            //Your vacation wants


            bool yourNeeds = beach && city;
            //answers True
            bool friendNeeds = beach || hiking;
            //answers True

            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision);

        }
    }
}




