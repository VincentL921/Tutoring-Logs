using OfficeClassesLesson;

var buildings = new List<Building>();

var office = new Building();
office.Tenant = new Tenant();
office.Tenant.People = new List<Occupants>();
office.Location = new Location();


office.UsageType = "Commercial Office";
office.BuildingType = "Public Building";

office.Tenant.Name = "Gotham Drywall";
office.Tenant.Industry = "Construction";
office.Tenant.TenantType = "Private Company";

office.Location.Street = "Green Street";
office.Location.City = "Brooklyn";
office.Location.City = "New York";

var employeeOne = new Occupants();
employeeOne.FirstName = "Vincent";
employeeOne.LastName = "Lentini";
employeeOne.Age = 27;

office.Tenant.People.Add(employeeOne);



var home = new Building();
home.Tenant = new Tenant();
home.Tenant.People = new List<Occupants>();
home.Location = new Location();

home.UsageType = "Tenant Building";
home.BuildingType = "Private Building";

home.Tenant.Name = "Vincent Lentini";
home.Tenant.Industry = "Rent";
home.Tenant.TenantType = "Apartment Tenant";

home.Location.Street = "Bedford Ave";
home.Location.City = "Brooklyn";
home.Location.State = "New York";


var renterOne = new Occupants();
renterOne.FirstName = "Vincent";
renterOne.LastName = "Lentini";
renterOne.Age = 27;

var renterTwo = new Occupants();
renterTwo.FirstName = "Ferris";
renterTwo.LastName = "Lentini";
renterTwo.Age = 10;

home.Tenant.People.Add(renterOne);
home.Tenant.People.Add(renterTwo);


buildings.Add(office);
buildings.Add(home);

foreach (var item in buildings)
{
    Console.WriteLine($"{item.BuildingType} has a count of {item.Tenant.People.Count()} & the primary tennant is {item.Tenant.Name}");

    foreach (var pItem in item.Tenant.People)
    {
        Console.WriteLine($"{pItem.FirstName}, {pItem.LastName}, {pItem.Age}");

    }
}
