using System.Security.Cryptography;
using RestaurantMenuWithClassesProject;
List<Menu> food = new List<Menu>();
//List<UserInput> answer = new List<UserInput>();

var m1 = new Menu();
var m2 = new Menu();
var m3 = new Menu();
var m4 = new Menu();
var m5 = new Menu();

var a1 = new Menu();
var i1 = new Menu();


m1.MenuItems = "Pizza";
m2.MenuItems = "Pasta";
m3.MenuItems = "Chicken Parm";
m4.MenuItems = "Meatballs";
m5.MenuItems = "Soda";

m1.ItemNumbers = 1;
m2.ItemNumbers = 2;
m3.ItemNumbers = 3;
m4.ItemNumbers = 4;
m5.ItemNumbers = 5;

a1.Input = Console.ReadLine();
i1.IndexOfItems = 0;

food.Add(m1);
food.Add(m2);
food.Add(m3);
food.Add(m4);
food.Add(m5);

food.Add(a1);
food.Add(i1);

List<Menu> menuItems = new List<Menu>();
List<Menu> itemNumbers = new List<Menu>();

Console.WriteLine("Welcome to Vin's Pizza!");
Console.WriteLine($"Please Begin Order:");
Console.WriteLine($"#1 - Pizza");
Console.WriteLine($"#2 - Pasta");
Console.WriteLine($"#3 - Chicken Parm");
Console.WriteLine($"#4 - Meatballs");
Console.WriteLine($"#5 - Soda");

foreach (Menu item in food)
{
    menuItems.Add(item);
    itemNumbers.Add(item);
    //Made seperate list classes to make the matching numbers warning.
}

if (menuItems.Count != itemNumbers.Count)
{
    Console.WriteLine("Warning: Menu Items are not equal to Item Numbers");
    //Made seperate list classes to make the matching numbers warning.
}

int indexOfItems = 0;

foreach (Menu mItem in food)
{
    Console.WriteLine("What would you like?");
    string menuInput = mItem.Input;
    bool parsedInput = int.TryParse(mItem.Input, out int inputAsInt);

    while ((inputAsInt == 0) || (inputAsInt > 5) || (!int.TryParse(menuInput, out inputAsInt)))
    {
        Console.WriteLine("Invalid Order. Please order a food item within range:");
        menuInput = mItem.Input;
        parsedInput = int.TryParse(menuInput, out inputAsInt);
        continue;
    }

    mItem.ItemNumbers.Equals(inputAsInt);
    indexOfItems += 1;
    for (mItem.IndexOfItems = 0; mItem.IndexOfItems < indexOfItems; mItem.IndexOfItems++)
    {
        var translationNumber = mItem.ItemNumbers.Equals(mItem.IndexOfItems);
        var translationOfUserInput = mItem.MenuItems.Equals(translationNumber);
        Console.WriteLine($"Your order: {translationOfUserInput}!");
    }
    Console.WriteLine("Thank you for your order. Please press Enter to checkout/continue!");
}

//It wont print the beginning correctly like it was recently. Not it's stuck in an infinite loop.
//May have to redo the input loop from scratch.



//In console:
//"Welcome to ABC"
//"Then, Please enter your selections with food item #"
//User needs to make their orders by inputting the cood item #
//*If they order out of the range, print out a re-try to please order the items within range
//**DONT HAVE THE MENU DISPLAY CODE TWICE**
//**DO NOT DUPLICATE CODE**
//{ "Pizza", "Pasta", "Chicken Parm", "Meatballs", "Soda" };