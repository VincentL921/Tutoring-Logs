using BeachClassesExercise;

var beaches = new List <BeachProfile>();

var ppb = new BeachProfile();
ppb.Location = new BeachLocation();
ppb.People = new List<Pedestrians>();


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
employees1.Area.AreaOfWork = "Beach";

employees2.RoleOfPerson = "Tour Guides";
employees2.Area.AreaOfWork = "Boardwalk";

employees3.RoleOfPerson = "Police Officers";
employees3.Area.AreaOfWork = "Boardwalk";

employees4.RoleOfPerson = "Boardwalk Staff";
employees4.Area.AreaOfWork = "Boardwalk";

employees5.RoleOfPerson = "Firefighters";
employees5.Area.AreaOfWork = "Boardwalk";

employees6.RoleOfPerson = "Restaurant Staff";
employees6.Area.AreaOfWork = "Boardwalk";

var tourists1 = new Pedestrians();
var tourists2 = new Pedestrians();
var tourists3 = new Pedestrians();
var tourists4 = new Pedestrians();
var tourists5 = new Pedestrians();
var tourists6 = new Pedestrians();

tourists1.RoleOfPerson = "Tourists";
tourists1.Area.AreaOfLeisure = "Boardwalk";

tourists2.RoleOfPerson = "Beachgoers";
tourists2.Area.AreaOfLeisure = "Beach";

tourists3.RoleOfPerson = "Clubbers";
tourists3.Area.AreaOfLeisure = "Beach";

tourists4.RoleOfPerson = "Kids";
tourists4.Area.AreaOfLeisure = "Boardwalk";

tourists5.RoleOfPerson = "Parents";
tourists5.Area.AreaOfLeisure = "Boardwalk";

tourists6.RoleOfPerson = "Teens";
tourists6.Area.AreaOfLeisure = "Boardwalk";


//ppb.People.Add(employees1);


//ppb.People.Add(employees1);
//ppb.People.Add(employees2);
//ppb.People.Add(employees3);
//ppb.People.Add(employees4);
//ppb.People.Add(employees5);
//ppb.People.Add(employees6);

//ppb.People.Add(tourists1);
//ppb.People.Add(tourists2);
//ppb.People.Add(tourists3);
//ppb.People.Add(tourists4);
//ppb.People.Add(tourists5);
//ppb.People.Add(tourists6);


Console.WriteLine($"{ppb.People.Count()}");



