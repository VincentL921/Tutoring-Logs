using System;

var car = new Car();

car.Drive(20, 5);


public class Car
{

    public void Drive(int totalMiles, int milesToFirstBreak)
    {
        while (totalMiles > 0)
        {
            totalMiles--;

            if (totalMiles == milesToFirstBreak)
            {
                //Console.WriteLine("Taking a break, letting partner drive this mile");
                Console.WriteLine("Oh no our car broke down");
                break;
                //continue;
            }

            Console.WriteLine($"I've got {totalMiles} left to go");
        }

        if (totalMiles > 0)
        {
            Console.WriteLine("We didn't reach our destination");
        }
        else
        {
            Console.WriteLine("We made it to walmart");
        }
    }
}