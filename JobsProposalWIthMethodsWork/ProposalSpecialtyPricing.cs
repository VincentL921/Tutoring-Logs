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
        
        private List<string> AllowedDivisions { get; set; }

        public ProposalSpecialtyPricing()
        {
            this.AllowedDivisions = new List<string>();
            this.AllowedDivisions.Add("David Inc");
            this.AllowedDivisions.Add("Vincent Bros Inc");
            this.AllowedDivisions.Add("Gotham LLC");
        }

        #region Overloaded Method Examples

        public void Build(string division, string vendor, string specsAndFinish, int price)
        {
            this.BuildPricing(division, vendor, specsAndFinish, price, false);
        }
        
        public void Build(string division, string vendor, string specsAndFinish, int price, bool needsInstaller)
        {
            this.BuildPricing(division, vendor, specsAndFinish, price, needsInstaller);
        }

        private void BuildPricing(string division, string vendor, string specsAndFinish, int price, bool needsInstaller)
        {
            //if (this.AllowedDivisions.Contains(division) == false)
            //if (!this.AllowedDivisions.Contains(division))
            if (!this.AllowedDivisions.Contains(division))
            {
                throw new ArgumentException($"{division} is not an allowed division");
            }

            this.SpecialPricingDivision = division;
            this.OptionalSpecialPricingVendorName = vendor;
            this.OptionalItemSpecsAndFinish = specsAndFinish;
            this.SpecialtyPricingProposalPrice = price;
            this.DoesThisVendorNeedItsOwnInstaller = needsInstaller;
        }

        #endregion
        
        public void DoorSpecialtyPricing()
        {
            this.SpecialPricingDivision = "Furnish All New Hollow Metal Doors, Frames & Hardware";
            this.OptionalSpecialPricingVendorName = "AAA Doors & HArdware";
            this.SpecialtyPricingProposalPrice = 11000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
        }

        public void ACTSpecialPricing()
        {
            this.SpecialPricingDivision = "F & I Acoustical Ceiling Tile & Grid";
            this.OptionalSpecialPricingVendorName = "Metro Interiors Constriction Supply";
            this.OptionalItemSpecsAndFinish = "USG Glacier 2\'x2\' ACT - White Finish - 15/16\" Donn Grid";
            this.SpecialtyPricingProposalPrice = 150000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
        }

        public void ArkturaSC1SpecialPricing()
        {
            this.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC1";
            this.OptionalSpecialPricingVendorName = "Urban Office";
            this.OptionalItemSpecsAndFinish = "Arktura Softshapes Grid Ceiling";
            this.SpecialtyPricingProposalPrice = 30000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
        }

        public void ArkturaSC2SpecialPricing()
        {
            this.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC2";
            this.OptionalSpecialPricingVendorName = "Urban Office";
            this.OptionalItemSpecsAndFinish = "Arktura SoftGrid Quad Ceiling";
            this.SpecialtyPricingProposalPrice = 40000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
        }

        public void ArkturaSC3SpecialPricing()
        {
            this.SpecialPricingDivision = "F & I Arktura metal ceiling SC2";
            this.OptionalSpecialPricingVendorName = "Urban Office";
            this.OptionalItemSpecsAndFinish = "Arktura Atmosphera Rise Ceiling";
            this.SpecialtyPricingProposalPrice = 40000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
        }

        public void ArmstrongMetalCeilingSpecialPricing()
        {
            this.SpecialPricingDivision = "F & I Armstrong Metalworks Ceiling";
            this.OptionalSpecialPricingVendorName = "Kamco";
            this.OptionalItemSpecsAndFinish = "AArmstrong Metsalworks - Wood look finish";
            this.SpecialtyPricingProposalPrice = 40000;
            this.DoesThisVendorNeedItsOwnInstaller = false;
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
