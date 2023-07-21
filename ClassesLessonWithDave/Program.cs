using System.Collections.Generic;

var apartment = new ApartmentComplex();
apartment.Location = new Location();
apartment.Units = new List<Unit>();


apartment.Location.State = "NY";
apartment.Location.StreetName = "100 main street";
apartment.Location.City = "Queens";


var floorUnit = new Unit();
floorUnit.FrontDoor = new Door();
floorUnit.BackDoor = new Door();

floorUnit.FrontDoor.Material = "WALNUT";
floorUnit.BackDoor.Material = "Pie";

floorUnit.LivingRoomWindow = new Window();
floorUnit.KitchenWindow = new Window();
floorUnit.BedRoomWindow = new Window();



var topUnit = new Unit();
topUnit.FrontDoor = new Door();
topUnit.BackDoor = new Door();

topUnit.FrontDoor.Material = "Zebra Wood";
topUnit.BackDoor.Material = "Oak";

topUnit.LivingRoomWindow = new Window();
topUnit.KitchenWindow = new Window();
topUnit.BedRoomWindow = new Window();



apartment.Units.Add(floorUnit); //add infinite amount of variables
apartment.Units.Add(topUnit); //add infinite amount of variables


Console.WriteLine($"My apartment is located in {apartment.Location.State} and it has {apartment.Units.Count} unit(s)");

foreach (var item in apartment.Units)
{
    Console.WriteLine($"This units front door is made of {item.FrontDoor.Material}");
}

public class ApartmentComplex
{
    public Location Location { get; set; }

    public List<Unit> Units { get; set; }
}

public class Unit
{
    public Door FrontDoor { get; set; }
    public Door BackDoor { get; set; }

    public Window LivingRoomWindow { get; set; }
    public Window BedRoomWindow { get; set; }
    public Window KitchenWindow { get; set; }
}

public class Window
{
    public string WindowType { get; set; }
    public string Color { get; set; }
}
public class Door
{
    public string Location { get; set; }
    public string Material { get; set; }
    public bool IsOpened { get; set; }
}


public class Location
{
    public string StreetName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}