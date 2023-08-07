using System.Collections.Generic;
using System.Linq;
using JobsProposalWIthMethodsWork;
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

samsungPennOne.DisplayProposal();
//having trouble implementing it into the code now

var specialPriceTotal = (samsungHMDoorPricing.SpecialtyPricingProposalPrice + samsungArmstrongMetalWorksPricing.SpecialtyPricingProposalPrice +
    samsungArkturaSC3CeilingPricing.SpecialtyPricingProposalPrice + samsungArkturaSC2CeilingPricing.SpecialtyPricingProposalPrice +
    samsungArkturaSC1CeilingPricing.SpecialtyPricingProposalPrice + samsungActCeilingPricing.SpecialtyPricingProposalPrice);



int drywallTotalNotInForeachLoop = (samsungPennOne.FAndIDrywallPartitions + samsungPennOne.FAndIGypsumCeilingsAndSoffits + samsungPennOne.ProvidanceOfWallBlocking + samsungPennOne.ProvidanceOfCeilingBlocking
    + samsungPennOne.ProvidanceOfExistingWallPatching + samsungPennOne.ProvidanceOfExistingCeilingPatching + samsungPennOne.ProvideFramingForNotOurTradeCeilings +
    samsungPennOne.InstallBathroomAccessories + samsungPennOne.InstallDoorsFramesAndHardware);


Console.WriteLine($"Total for Additional Items: {specialPriceTotal}");
Console.WriteLine($"");
Console.WriteLine($"Overall Total: {drywallTotalNotInForeachLoop + specialPriceTotal}");

