using System;

var race = new Race10k();

race.StartRace();
race.StartRace();
race.StartRace();
race.StartRace();


public class Race10k
{
    private bool isRaceStarted = false;

    public void StartRace()
    {
        if (isRaceStarted == true)
        {
            Console.WriteLine("Already started, can't start an already started race");
            return;
        }

        isRaceStarted = true;
        Console.WriteLine("Race has started");
    }
}

