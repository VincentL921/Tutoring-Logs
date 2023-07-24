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
var a2 = new Menu();
var a3 = new Menu();
var a4 = new Menu();
var a5 = new Menu();

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
a2.Input = Console.ReadLine();
a3.Input = Console.ReadLine();
a4.Input = Console.ReadLine();
a5.Input = Console.ReadLine();

food.Add(m1);
food.Add(m2);
food.Add(m3);
food.Add(m4);
food.Add(m5);

food.Add(a1);
food.Add(a2);
food.Add(a3);
food.Add(a4);
food.Add(a5);

List<Menu> menuItems = new List<Menu>();
List<Menu> itemNumbers = new List<Menu>();

foreach (Menu item in food)
{
    menuItems.Add(item);
    itemNumbers.Add(item);
    //Made seperate list classes to make the matching numbers warning.
}

Console.WriteLine("Welcome to Vin's Pizza!");

if (menuItems.Count != itemNumbers.Count)
{
    Console.WriteLine("Warning: Menu Items are not equal to Item Numbers");
    //Made seperate list classes to make the matching numbers warning.
}

int indexOfItems = 0;
Console.WriteLine($"Please Begin Order:");
Console.WriteLine($"#1 - Pizza");
Console.WriteLine($"#2 - Pasta");
Console.WriteLine($"#3 - Chicken Parm");
Console.WriteLine($"#4 - Meatballs");
Console.WriteLine($"#5 - Soda");

foreach (Menu mItem in food)
{
    Console.WriteLine("What would you like?");
    string menuInput = Console.ReadLine();
    mItem.Input;
    bool parsedInput = int.TryParse(menuInput, out inputAsInt);

    while ((inputAsInt == 0) || (inputAsInt > 5) || (!int.TryParse(menuInput, out inputAsInt)))
    {
        Console.WriteLine("Invalid Order. Please order a food item within range:");
        menuInput = Console.ReadLine();
        parsedInput = int.TryParse(menuInput, out inputAsInt);
    }

    itemNumbers[indexOfItems] = inputAsInt;
    indexOfItems += 1;
    //int translationNumber = 0;

    for (int i = 0; i < indexOfItems; i++)
    {
        int translationNumber = itemNumbers[i];
        string translationOfUserInput = menuItems[translationNumber - 1];
        Console.WriteLine($"Your order: {translationOfUserInput}!");
    }
    Console.WriteLine("Thank you for your order. Please press Enter to checkout/continue!");
}




//In console:
//"Welcome to ABC"
//"Then, Please enter your selections with food item #"
//User needs to make their orders by inputting the cood item #
//*If they order out of the range, print out a re-try to please order the items within range
//**DONT HAVE THE MENU DISPLAY CODE TWICE**
//**DO NOT DUPLICATE CODE**
//{ "Pizza", "Pasta", "Chicken Parm", "Meatballs", "Soda" };