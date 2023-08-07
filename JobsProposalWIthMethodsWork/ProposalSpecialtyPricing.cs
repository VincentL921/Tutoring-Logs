using System;
namespace JobsProposalWIthMethodsWork
{
	public class ProposalSpecialtyPricing
	{
        public string SpecialPricingDivision { get; set; }
        public string OptionalSpecialPricingVendorName { get; set; }
        public string OptionalItemSpecsAndFinish { get; set; }
        public int SpecialtyPricingProposalPrice { get; set; }
        public bool DoesThisVendorNeedItsOwnInstaller { get; set; }

        public ProposalSpecialtyPricing()
		{
		}
	}
}


//public void PlaceOrder(string menuInput)
//{
//    bool isInteger = int.TryParse(menuInput, out int inputAsInt);

//    while (menuInput != "EXIT" && ((inputAsInt == 0) || (inputAsInt > this.MenuItems.Count) || (!isInteger && menuInput != "EXIT")))
//    {
//        Console.WriteLine("Invalid Order. Please order a food item within range:");
//        menuInput = Console.ReadLine();
//        isInteger = int.TryParse(menuInput, out inputAsInt);
//    }

//    this.SelectedItems.Add(inputAsInt);
//}

//public void DisplayMenu()
//{
//    var counter = 1;
//    foreach (var item in this.MenuItems)
//    {
//        Console.WriteLine($"#{counter} - {item}");

//        counter++;
//    }
//}

//public void DisplaySelections()
//{
//    foreach (var item in this.SelectedItems)
//    {
//        // Add guard clause to prevent error when typing in EXIT to close the program / stop prompting for user input
//        if (item == 0)
//        {
//            continue;
//        }

//        var selectedItemNumber = item - 1;
//        //var translationOfUserInput = m1.MenuItems.Equals(selectedItemNumber);
//        //Don't use equals, when accessing a list by index, use [], for the selected item# - subtract 1.
//        var translationOfUserInput = this.MenuItems[selectedItemNumber];
//        Console.WriteLine($"Your order: {translationOfUserInput}!");
//    }
//}
