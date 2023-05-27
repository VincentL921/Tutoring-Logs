using System;

public class Car
{
    private bool isEngineRunning = false;

    public void StartEngine()
    {
        if (isEngineRunning)
        {
            return;
        }

        Console.WriteLine("Engine is on");
        isEngineRunning = true;
    }

    public void StopEngine()
    {
        if (!isEngineRunning)
        {
            Console.WriteLine("dont print anything");
            return;
        }

        Console.WriteLine("Engine is off");
        isEngineRunning = false;
    }

    public bool IsEngineRunning()
    {
        return isEngineRunning;
    }

    public void DriveCar()
    {
        if (!isEngineRunning)
        {
            Console.WriteLine("You must start the car first");
            return;
        }

        Console.WriteLine("We are going to walmart");
    }
}