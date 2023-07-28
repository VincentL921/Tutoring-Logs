using System.Security.Cryptography;
using RestaurantMenuWithClassesProject;
var m1 = new Menu();
m1.MenuItems = new List<string>();
m1.SelectedItems = new List<int>();


m1.MenuItems.Add("Pizza");
m1.MenuItems.Add("Pasta");
m1.MenuItems.Add("Chicken Parm");
m1.MenuItems.Add("Meatballs");
m1.MenuItems.Add("Soda");
m1.MenuItems.Add("Chicken Carbonara");

//m1.ItemNumbers = 1;

Console.WriteLine("Welcome to Vin's Pizza!");
Console.WriteLine($"Please Begin Order:");

// Replace hard coded menu display with dynamic foreach loop below
//Console.WriteLine($"#1 - Pizza");
//Console.WriteLine($"#2 - Pasta");
//Console.WriteLine($"#3 - Chicken Parm");
//Console.WriteLine($"#4 - Meatballs");
//Console.WriteLine($"#5 - Soda");

var counter = 1;
foreach (var item in m1.MenuItems)
{
    Console.WriteLine($"#{counter} - {item}");

    counter++;
}

//Alternative to foreach loop that uses counter, can do for loop with i+1 as the counter.
//for (int i = 0; i < m1.MenuItems.Count; i++)
//{
//    Console.WriteLine($"#{i+1} - {m1.MenuItems[i]}");
//}

//Hold over from array work, don't need when dealing with lists/collections that allow complex objects 
//  complex objects meaning classes / something other than int/string...etc.
//if (menuItems.Count != itemNumbers.Count)
//{
//    Console.WriteLine("Warning: Menu Items are not equal to Item Numbers");
//    //Made seperate list classes to make the matching numbers warning.
//}

int indexOfItems = 0;

string menuInput = "";

while(menuInput != "EXIT")
//foreach (var mItem in m1.MenuItems)
{
    Console.WriteLine("What would you like?");
    //string menuInput = mItem.Input;
    menuInput = Console.ReadLine();
    //bool parsedInput = int.TryParse(mItem.Input, out int inputAsInt);
    //Renamed parsedInput to isInteger
    
    bool isInteger = int.TryParse(menuInput, out int inputAsInt);

    //while ((inputAsInt == 0) || (inputAsInt > 5) || (!int.TryParse(menuInput, out inputAsInt)))

    //change inputAsInt > 5 to inputAsInt > m1.MenuItems.Count so it will support however many menu items are in the MenuItems collection
    while (menuInput != "EXIT" && ((inputAsInt == 0) || (inputAsInt > m1.MenuItems.Count) || (!isInteger && menuInput != "EXIT")))
    {
        Console.WriteLine("Invalid Order. Please order a food item within range:");
        //Not sure if this is needed, commenting out for now
        //menuInput = mItem.Input;
        menuInput = Console.ReadLine();

        //Not being used anywhere, can remove
        //parsedInput = int.TryParse(menuInput, out inputAsInt);
        isInteger = int.TryParse(menuInput, out inputAsInt);
    }

    m1.SelectedItems.Add(inputAsInt);
    
    //mItem.ItemNumbers.Equals(inputAsInt);
    //indexOfItems += 1;
    //for (mItem.IndexOfItems = 0; mItem.IndexOfItems < indexOfItems; mItem.IndexOfItems++)
    //{
    //    var translationNumber = mItem.ItemNumbers.Equals(mItem.IndexOfItems);
    //    var translationOfUserInput = mItem.MenuItems.Equals(translationNumber);
    //    Console.WriteLine($"Your order: {translationOfUserInput}!");
    //}


    foreach (var item in m1.SelectedItems)
    {
        // Add guard clause to prevent error when typing in EXIT to close the program / stop prompting for user input
        if (item == 0)
        {
            continue;
        }

        var selectedItemNumber = item - 1;
        //var translationOfUserInput = m1.MenuItems.Equals(selectedItemNumber);
        //Don't use equals, when accessing a list by index, use [], for the selected item# - subtract 1.
        var translationOfUserInput = m1.MenuItems[selectedItemNumber];
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