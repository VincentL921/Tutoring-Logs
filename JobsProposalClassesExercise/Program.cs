using JobsProposalClassesExercise;
//var proposal = new BidProposal();

List<BidProposal> project = new List<BidProposal>();
var samsungPennOne = new BidProposal();

samsungPennOne.bidInformation = new BidInformation();
samsungPennOne.SpecialPricingLineItems = new List<ProposalSpecialtyPricing>();
var samsungHMDoorPricing = new ProposalSpecialtyPricing();
var samsungActCeilingPricing = new ProposalSpecialtyPricing();
var samsungArkturaSC1CeilingPricing = new ProposalSpecialtyPricing();
var samsungArkturaSC2CeilingPricing = new ProposalSpecialtyPricing();
var samsungArkturaSC3CeilingPricing = new ProposalSpecialtyPricing();
var samsungArmstrongMetalWorksPricing = new ProposalSpecialtyPricing();


samsungPennOne.bidInformation.ProjectName = "VNO Samsung Penn 1 Office";
samsungPennOne.bidInformation.ProjectClient = "Turner Construction";
samsungPennOne.bidInformation.TypeOfConstruction = "Interior Office Fit-Out";
samsungPennOne.bidInformation.TodaysDate = "7/28/2023";
samsungPennOne.bidInformation.VersionOfBid = "Original Bid";
samsungPennOne.bidInformation.BluePrintAddendum = "Addendum #2 Drawings";
samsungPennOne.bidInformation.BluePrintDates = "July 10th, 2023";

samsungPennOne.FAndIDrywallPartitions = 100000;
samsungPennOne.FAndIGypsumCeilingsAndSoffits = 100000;
samsungPennOne.InstallBathroomAccessories = 1500;
samsungPennOne.InstallDoorsFramesAndHardware = 3000;
samsungPennOne.ProvidanceOfWallBlocking = 5000;
samsungPennOne.ProvidanceOfCeilingBlocking = 5000;
samsungPennOne.ProvidanceOfExistingWallPatching = 7000;
samsungPennOne.ProvidanceOfExistingCeilingPatching = 7000;
samsungPennOne.ProvideFramingForNotOurTradeCeilings = 11000;


samsungHMDoorPricing.SpecialPricingDivision = "Furnish All New Hollow Metal Doors, Frames & Hardware";
samsungHMDoorPricing.OptionalSpecialPricingVendorName = "AAA Doors & HArdware";
samsungHMDoorPricing.SpecialtyPricingProposalPrice = 11000;
samsungHMDoorPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungActCeilingPricing.SpecialPricingDivision = "F & I Acoustical Ceiling Tile & Grid";
samsungActCeilingPricing.OptionalSpecialPricingVendorName = "Metro Interiors Constriction Supply";
samsungActCeilingPricing.OptionalItemSpecsAndFinish = "USG Glacier 2\'x2\' ACT - White Finish - 15/16\" Donn Grid";
samsungActCeilingPricing.SpecialtyPricingProposalPrice = 150000;
samsungActCeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC1CeilingPricing.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC1";
samsungArkturaSC1CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC1CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Softshapes Grid Ceiling";
samsungArkturaSC1CeilingPricing.SpecialtyPricingProposalPrice = 30000;
samsungArkturaSC1CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC2CeilingPricing.SpecialPricingDivision = "F & I Arktura Metal Ceiling SC2";
samsungArkturaSC2CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC2CeilingPricing.OptionalItemSpecsAndFinish = "Arktura SoftGrid Quad Ceiling";
samsungArkturaSC2CeilingPricing.SpecialtyPricingProposalPrice = 40000;
samsungArkturaSC2CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC3CeilingPricing.SpecialPricingDivision = "F & I Arktura metal ceiling SC2";
samsungArkturaSC3CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC3CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Atmosphera Rise Ceiling";
samsungArkturaSC3CeilingPricing.SpecialtyPricingProposalPrice = 40000;
samsungArkturaSC3CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArmstrongMetalWorksPricing.SpecialPricingDivision = "F & I Armstrong Metalworks Ceiling";
samsungArmstrongMetalWorksPricing.OptionalSpecialPricingVendorName = "Kamco";
samsungArmstrongMetalWorksPricing.OptionalItemSpecsAndFinish = "AArmstrong Metsalworks - Wood look finish";
samsungArmstrongMetalWorksPricing.SpecialtyPricingProposalPrice = 40000;
samsungArmstrongMetalWorksPricing.DoesThisVendorNeedItsOwnInstaller = false;

//^^detailed backend info that goes into what is needed to back up and build an official proposal to present to the client.

samsungPennOne.SpecialPricingLineItems.Add(samsungHMDoorPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArmstrongMetalWorksPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC3CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC2CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC1CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungActCeilingPricing);

project.Add(samsungPennOne);

//var sum = initList.Where(item => item.B != null).Sum(item => item.A);
//tried to use LINQ to get the drywall sum but was failing immensely lol. Did a standard sum for it.

foreach (var item in project)
{
    Console.WriteLine($"Gotham Drywall Inc");
    Console.WriteLine($"");
    Console.WriteLine($"Project Name: {item.bidInformation.ProjectName}");
    Console.WriteLine($"Attention To: {item.bidInformation.ProjectClient}");
    Console.Write($"Date: {item.bidInformation.TodaysDate}");
    Console.Write($"");
    Console.WriteLine($"  Bid Revision: {item.bidInformation.VersionOfBid}");
    Console.Write($"This bid is based off of: {item.bidInformation.BluePrintAddendum}");
    Console.Write($", dated {item.bidInformation.BluePrintDates} ");

    Console.WriteLine($"");
    Console.WriteLine($"");
    Console.WriteLine($"");
    Console.WriteLine($"28th Floor, Samsung Office:");
    Console.WriteLine($"1. F & I Drywall Partiitons: {item.FAndIDrywallPartitions}");
    Console.WriteLine($"2. GWB Ceilings & Soffits: {item.FAndIGypsumCeilingsAndSoffits}");
    Console.WriteLine($"3. Providance of Wall Blocking: {item.ProvidanceOfWallBlocking}");
    Console.WriteLine($"4. Providance of Ceiling Blocking: {item.ProvidanceOfCeilingBlocking}");
    Console.WriteLine($"5. Providance Allowance to patch existing walls: {item.ProvidanceOfExistingWallPatching}");
    Console.WriteLine($"6. Providance Allowance to patch existing ceilings: {item.ProvidanceOfExistingCeilingPatching}");
    Console.WriteLine($"7. Providance of framing & plywood to millwork light ceiling: {item.ProvideFramingForNotOurTradeCeilings}");
    Console.WriteLine($"8. Install only all bathroom accessories: {item.InstallBathroomAccessories}");
    Console.WriteLine($"9. Install all doors, frames & hatrdware: {item.InstallDoorsFramesAndHardware}");
    Console.WriteLine($"");

    int drywallTotal = (item.FAndIDrywallPartitions + item.FAndIGypsumCeilingsAndSoffits + item.ProvidanceOfWallBlocking + item.ProvidanceOfCeilingBlocking
        + item.ProvidanceOfExistingWallPatching + item.ProvidanceOfExistingCeilingPatching + item.ProvideFramingForNotOurTradeCeilings +
        item.InstallBathroomAccessories + item.InstallDoorsFramesAndHardware);

    Console.WriteLine($"Drywall Total: {drywallTotal}");

    Console.WriteLine($"");
    Console.WriteLine($"Additional Items:");

    foreach (var pItem in item.SpecialPricingLineItems)
    {
        Console.WriteLine($"{pItem.SpecialPricingDivision}: {pItem.SpecialtyPricingProposalPrice}");
    }
}



//samsungPennOne.FAndIDrywallPartitions = 100000;
//samsungPennOne.FAndIGypsumCeilingsAndSoffits = 100000;
//samsungPennOne.InstallBathroomAccessories = 1500;
//samsungPennOne.InstallDoorsFramesAndHardware = 3000;
//samsungPennOne.ProvidanceOfWallBlocking = 5000;
//samsungPennOne.ProvidanceOfCeilingBlocking = 5000;
//samsungPennOne.ProvidanceOfExistingWallPatching = 7000;
//samsungPennOne.ProvidanceOfExistingCeilingPatching = 7000;
//samsungPennOne.ProvideFramingForNotOurTradeCeilings = 11000;
