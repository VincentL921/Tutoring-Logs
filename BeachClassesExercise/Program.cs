using BeachClassesExercise;

var beaches = new List <BeachProfile>();

var ppb = new BeachProfile();
ppb.Location = new BeachLocation();
ppb.Area = new BeachAreas();
ppb.Area.People = new List<Pedestrians>();


ppb.UsageType = "Tourism";
ppb.TypeOfBeach = "Private Beach";


ppb.Location.City = "Point Pleasant Beach";
ppb.Location.State = "New Jersey";


beaches.Add(ppb);



var employees1 = new Pedestrians();
var employees2 = new Pedestrians();
var employees3 = new Pedestrians();
var employees4 = new Pedestrians();
var employees5 = new Pedestrians();
var employees6 = new Pedestrians();

employees1.RoleOfPerson = "Lifeguards";
employees1.AreaOfWork = "Beach";

employees2.RoleOfPerson = "Tour Guides";
employees2.AreaOfWork = "Boardwalk";

employees3.RoleOfPerson = "Police Officers";
employees3.AreaOfWork = "Boardwalk";

employees4.RoleOfPerson = "Boardwalk Staff";
employees4.AreaOfWork = "Boardwalk";

employees5.RoleOfPerson = "Firefighters";
employees5.AreaOfWork = "Boardwalk";

employees6.RoleOfPerson = "Restaurant Staff";
employees6.AreaOfWork = "Boardwalk";

var tourists1 = new Pedestrians();
var tourists2 = new Pedestrians();
var tourists3 = new Pedestrians();
var tourists4 = new Pedestrians();
var tourists5 = new Pedestrians();
var tourists6 = new Pedestrians();

tourists1.RoleOfPerson = "Tourists";
tourists1.AreaOfLeisure = "Boardwalk";

tourists2.RoleOfPerson = "Beachgoers";
tourists2.AreaOfLeisure = "Beach";

tourists3.RoleOfPerson = "Clubbers";
tourists3.AreaOfLeisure = "Beach";

tourists4.RoleOfPerson = "Kids";
tourists4.AreaOfLeisure = "Boardwalk";

tourists5.RoleOfPerson = "Parents";
tourists5.AreaOfLeisure = "Boardwalk";

tourists6.RoleOfPerson = "Teens";
tourists6.AreaOfLeisure = "Boardwalk";


//ppb.Area.People.Add(employees1);


ppb.Area.People.Add(employees1);
ppb.Area.People.Add(employees2);
ppb.Area.People.Add(employees3);
ppb.Area.People.Add(employees4);
ppb.Area.People.Add(employees5);
ppb.Area.People.Add(employees6);

ppb.Area.People.Add(tourists1);
ppb.Area.People.Add(tourists2);
ppb.Area.People.Add(tourists3);
ppb.Area.People.Add(tourists4);
ppb.Area.People.Add(tourists5);
ppb.Area.People.Add(tourists6);


//Console.WriteLine($"{ppb.Area.People.Count()}");

//commented these out to give the guard clause if statement a try. Update: I needed them lol

List<Pedestrians> Boardwalk = new List<Pedestrians>();
List<Pedestrians> Beach = new List<Pedestrians>();

foreach (var item in beaches)
{
    Console.WriteLine($"{item.Location.City} is a {item.TypeOfBeach} in {item.Location.State} that mainly markets in {item.UsageType}");

    //if (item.Area.AreaOfLeisure.Contains("Boardwalk"))
    //{
    //    Boardwalk.Add(item);
    //    continue;
    //}
    //Beach.Add(item);
}



