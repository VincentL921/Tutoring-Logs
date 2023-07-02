using System.Collections.Generic;
using CarCountryExercise;

List<Vehicle> car = new List<Vehicle>();

var c1 = new Vehicle();
var c2 = new Vehicle();
var c3 = new Vehicle();
var c4 = new Vehicle();
var c5 = new Vehicle();
var c6 = new Vehicle();
var c7 = new Vehicle();

c1.Car = "Camaro";
c2.Car = "X5";
c3.Car = "Bronco";
c4.Car = "4Runner";
c5.Car = "Charger";
c6.Car = "WRX";
c7.Car = "Golf";

c1.Brand = "Chevrolet";
c2.Brand = "BMW";
c3.Brand = "Ford";
c4.Brand = "Toyota";
c5.Brand = "Dodge";
c6.Brand = "Subaru";
c7.Brand = "Volkswagen";

c1.Country = "USA";
c2.Country = "Germany";
c3.Country = "USA";
c4.Country = "Japan";
c5.Country = "USA";
c6.Country = "Japan";
c7.Country = "Germany";

List<Vehicle> americanCars = new List<Vehicle>();
List<Vehicle> internationalCars = new List<Vehicle>();

foreach (Vehicle item in car)
{
    if(item.Country == string.Contains("USA"))
    {
        americanCars.Add(item);
        continue;
    }
    internationalCars.Add(item);

    }

Console.WriteLine($"Number of American Cars: {americanCars.Count}");
Console.WriteLine($"Number of International Cars: {internationalCars.Count}");


// if (!item.Country.Contains("USA"))
//{
//      internationalCars.Add(item);
//}




