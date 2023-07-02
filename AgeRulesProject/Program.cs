using AgeRulesProject;

List<Person> people = new List<Person>();

var p1 = new Person();
var p2 = new Person();
var p3 = new Person();
var p4 = new Person();
var p5 = new Person();
var p6 = new Person();
var p7 = new Person();

p1.FirstName = "Alex";
p2.FirstName = "Amber";
p3.FirstName = "Adam";
p4.FirstName = "Bob";
p5.FirstName = "Bill";
p6.FirstName = "Carl";
p7.FirstName = "Chris";

p1.Age = 10;
p2.Age = 17;
p3.Age = 19;
p4.Age = 25;
p5.Age = 20;
p6.Age = 27;
p7.Age = 21;

p1.State = "New Jersey";
p2.State = "New York";
p3.State = "Georgia";
p4.State = "Florida";
p5.State = "California";
p6.State = "North Carolina";
p7.State = "Pennsylvania";

people.Add(p1);
people.Add(p2);
people.Add(p3);
people.Add(p4);
people.Add(p5);
people.Add(p6);
people.Add(p7);

List<Person> minors = new List<Person>();
List<Person> drivers = new List<Person>();
List<Person> smokers = new List<Person>();
List<Person> adults = new List<Person>();

foreach (Person item in people)
{
    //Age greater than 21
    //Age >= 18 && Age < 21
    //Age >= 16 && Age < 18

    if (item.Age >= 21)
    {
        adults.Add(item);
        continue;
    }
    if (item.Age >= 18 && item.Age < 21)
    {
        drivers.Add(item);
        continue;
    }
    if (item.Age >= 16 && item.Age < 18)
    {
        smokers.Add(item);
        continue;
    }
    minors.Add(item);
}
//print out how many people are in each list
Console.WriteLine($"List of Adults: {adults.Count}");
Console.WriteLine($"List of Smokers: {smokers.Count}");
Console.WriteLine($"List of drivers: {drivers.Count}");
Console.WriteLine($"List of minors: {minors.Count}");



