using System;
namespace JobsProposalWIthMethodsWork
{
	public class BidProposal
	{
        public int FAndIDrywallPartitions { get; set; }
        public int FAndIGypsumCeilingsAndSoffits { get; set; }
        public int InstallBathroomAccessories { get; set; }
        public int InstallDoorsFramesAndHardware { get; set; }
        public int ProvidanceOfWallBlocking { get; set; }
        public int ProvidanceOfCeilingBlocking { get; set; }
        public int ProvidanceOfExistingWallPatching { get; set; }
        public int ProvidanceOfExistingCeilingPatching { get; set; }
        public int ProvideFramingForNotOurTradeCeilings { get; set; }

        public BidInformation bidInformation { get; set; }
        public List<ProposalSpecialtyPricing> SpecialPricingLineItems { get; set; }

        //NOTE - dmw 8/7/2023
        //  So this is a great start on building out a method, its on the correct class (bid proposal) but the issue is that you've got it
        //  being responsible for more bid proposals other than itself, meaning you've got this singular class of 1 proposal responsible for
        //  displaying bid proposal for N number of jobs (meaning more jobs than just itself.
        //  
        // What you want to do when building out methods is make sure the method is contained to just the class you are working with
        //  (usually, there are plenty of exceptions but this is a good rule majority of the time).
        //
        //  So what i mean is, rather than passing in a collection of BidProposals, you would pass in nothing and just display the values
        //  already assigned to the class.
        //
        //  That means you'd remove the foreach loop that loops over "project" and all the variables where you have
        //  item.bidInformation.ProjectName would turn into this.bidInformation.ProjectName or item.SpecialtyLineItems would become this.SpecialtyLineItems.
        //
        //  Then, you'd leave the consumer of this class, the code that utilizes this class / "consumes" it, to be responsible with determining whether
        // it needs to display 1 proposal or multiple proposals worth of data.
        //
        //  So that means you'd leave the foreach loop in program.cs and call the proposal display method within program.cs, within the foreach loop

        //public void BidSpecialtyPricing()
        //{
        //    this.SpecialPricingLineItems.SpecialPricingDivision = "Furnish All New Hollow Metal Doors, Frames & Hardware";
        //    samsungHMDoorPricing.OptionalSpecialPricingVendorName = "AAA Doors & HArdware";
        //    samsungHMDoorPricing.SpecialtyPricingProposalPrice = 11000;
        //    samsungHMDoorPricing.DoesThisVendorNeedItsOwnInstaller = false;

        //    samsungActCeilingPricing.SpecialPricingDivision = "F & I Acoustical Ceiling Tile & Grid";
        //    samsungActCeilingPricing.OptionalSpecialPricingVendorName = "Metro Interiors Constriction Supply";
        //    samsungActCeilingPricing.OptionalItemSpecsAndFinish = "USG Glacier 2\'x2\' ACT - White Finish - 15/16\" Donn Grid";
        //    samsungActCeilingPricing.SpecialtyPricingProposalPrice = 150000;
        //    samsungActCeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

        //    samsungArkturaSC1CeilingPricing.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC1";
        //    samsungArkturaSC1CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
        //    samsungArkturaSC1CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Softshapes Grid Ceiling";
        //    samsungArkturaSC1CeilingPricing.SpecialtyPricingProposalPrice = 30000;
        //    samsungArkturaSC1CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

        //    samsungArkturaSC2CeilingPricing.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC2";
        //    samsungArkturaSC2CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
        //    samsungArkturaSC2CeilingPricing.OptionalItemSpecsAndFinish = "Arktura SoftGrid Quad Ceiling";
        //    samsungArkturaSC2CeilingPricing.SpecialtyPricingProposalPrice = 40000;
        //    samsungArkturaSC2CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

        //    samsungArkturaSC3CeilingPricing.SpecialPricingDivision = "F & I Arktura metal ceiling SC2";
        //    samsungArkturaSC3CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
        //    samsungArkturaSC3CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Atmosphera Rise Ceiling";
        //    samsungArkturaSC3CeilingPricing.SpecialtyPricingProposalPrice = 40000;
        //    samsungArkturaSC3CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

        //    samsungArmstrongMetalWorksPricing.SpecialPricingDivision = "F & I Armstrong Metalworks Ceiling";
        //    samsungArmstrongMetalWorksPricing.OptionalSpecialPricingVendorName = "Kamco";
        //    samsungArmstrongMetalWorksPricing.OptionalItemSpecsAndFinish = "AArmstrong Metsalworks - Wood look finish";
        //    samsungArmstrongMetalWorksPricing.SpecialtyPricingProposalPrice = 40000;
        //    samsungArmstrongMetalWorksPricing.DoesThisVendorNeedItsOwnInstaller = false;
        //}

        public void BaseBidPricing()
        {
            this.FAndIDrywallPartitions = 100000;
            this.FAndIGypsumCeilingsAndSoffits = 100000;
            this.InstallBathroomAccessories = 1500;
            this.InstallDoorsFramesAndHardware = 3000;
            this.ProvidanceOfWallBlocking = 5000;
            this.ProvidanceOfCeilingBlocking = 5000;
            this.ProvidanceOfExistingWallPatching = 7000;
            this.ProvidanceOfExistingCeilingPatching = 7000;
            this.ProvideFramingForNotOurTradeCeilings = 11000;
        }

        public void JobBidInformation()
        {
            this.bidInformation.ProjectName = "VNO Samsung Penn 1 Office";
            this.bidInformation.ProjectClient = "Turner Construction";
            this.bidInformation.TypeOfConstruction = "Interior Office Fit-Out";
            this.bidInformation.TodaysDate = "7/28/2023";
            this.bidInformation.VersionOfBid = "Original Bid";
            this.bidInformation.BluePrintAddendum = "Addendum #2 Drawings";
            this.bidInformation.BluePrintDates = "July 10th, 2023";

        }

        public void DisplayProposal()
        {
            Console.WriteLine($"Gotham Drywall Inc");
            Console.WriteLine($"");
            Console.WriteLine($"Project Name: {this.bidInformation.ProjectName}");
            Console.WriteLine($"Attention To: {this.bidInformation.ProjectClient}");
            Console.Write($"Date: {this.bidInformation.TodaysDate}");
            Console.Write($"");
            Console.WriteLine($"  Bid Revision: {this.bidInformation.VersionOfBid}");
            Console.Write($"This bid is based off of: {this.bidInformation.BluePrintAddendum}");
            Console.Write($", dated {this.bidInformation.BluePrintDates} ");

            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"28th Floor, Samsung Office:");
            Console.WriteLine($"1. F & I Drywall Partiitons: {this.FAndIDrywallPartitions}");
            Console.WriteLine($"2. GWB Ceilings & Soffits: {this.FAndIGypsumCeilingsAndSoffits}");
            Console.WriteLine($"3. Providance of Wall Blocking: {this.ProvidanceOfWallBlocking}");
            Console.WriteLine($"4. Providance of Ceiling Blocking: {this.ProvidanceOfCeilingBlocking}");
            Console.WriteLine($"5. Providance Allowance to patch existing walls: {this.ProvidanceOfExistingWallPatching}");
            Console.WriteLine($"6. Providance Allowance to patch existing ceilings: {this.ProvidanceOfExistingCeilingPatching}");
            Console.WriteLine($"7. Providance of framing & plywood to millwork light ceiling: {this.ProvideFramingForNotOurTradeCeilings}");
            Console.WriteLine($"8. Install only all bathroom accessories: {this.InstallBathroomAccessories}");
            Console.WriteLine($"9. Install all doors, frames & hatrdware: {this.InstallDoorsFramesAndHardware}");

            int drywallTotal = (this.FAndIDrywallPartitions + this.FAndIGypsumCeilingsAndSoffits + this.ProvidanceOfWallBlocking + this.ProvidanceOfCeilingBlocking
                + this.ProvidanceOfExistingWallPatching + this.ProvidanceOfExistingCeilingPatching + this.ProvideFramingForNotOurTradeCeilings +
                this.InstallBathroomAccessories + this.InstallDoorsFramesAndHardware);

            Console.WriteLine($"Drywall Total: {drywallTotal}");

            Console.WriteLine($"");
            Console.WriteLine($"Additional Items:");

            var specialPricingIndex = 1;
            foreach (var pItem in this.SpecialPricingLineItems)
            {
                Console.WriteLine($"{specialPricingIndex}. {pItem.SpecialPricingDivision}: {pItem.SpecialtyPricingProposalPrice}");
                specialPricingIndex++;
            }
        }

        //internal void DisplayProposal()
        //{
        //    throw new NotImplementedException();
        //}
        //For some reason this came up when I was trying to implement the method into my program

        public BidProposal()
		{
		}
	}
}

