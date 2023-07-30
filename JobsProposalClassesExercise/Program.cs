using JobsProposalClassesExercise;
//var proposal = new BidProposal();

List<BidProposal> project = new List<BidProposal>();
var samsungPennOne = new BidProposal();

samsungPennOne.bidInformation = new BidInformation();

samsungPennOne.SpecialPricingLineItems = new List <ProposalSpecialtyPricing>();
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


samsungHMDoorPricing.SpecialPricingDivision = "Furnish all new Hollow Metal Doors, Frames & Hardware";
samsungHMDoorPricing.OptionalSpecialPricingVendorName = "AAA Doors & HArdware";
samsungHMDoorPricing.SpecialtyPricingProposalPrice = 11000;
samsungHMDoorPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungActCeilingPricing.SpecialPricingDivision = "Acoustical Ceiling Tile & Grid";
samsungActCeilingPricing.OptionalSpecialPricingVendorName = "Metro Interiors Constriction Supply";
samsungActCeilingPricing.OptionalItemSpecsAndFinish = "USG Glacier 2\'x2\' ACT - White Finish - 15/16\" Donn Grid";
samsungActCeilingPricing.SpecialtyPricingProposalPrice = 150000;
samsungActCeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC1CeilingPricing.SpecialPricingDivision = "Arktura metal ceiling SC1";
samsungArkturaSC1CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC1CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Softshapes Grid Ceiling";
samsungArkturaSC1CeilingPricing.SpecialtyPricingProposalPrice = 30000;
samsungArkturaSC1CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC2CeilingPricing.SpecialPricingDivision = "Arktura metal ceiling SC2";
samsungArkturaSC2CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC2CeilingPricing.OptionalItemSpecsAndFinish = "Arktura SoftGrid Quad Ceiling";
samsungArkturaSC2CeilingPricing.SpecialtyPricingProposalPrice = 40000;
samsungArkturaSC2CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArkturaSC3CeilingPricing.SpecialPricingDivision = "Arktura metal ceiling SC2";
samsungArkturaSC3CeilingPricing.OptionalSpecialPricingVendorName = "Urban Office";
samsungArkturaSC3CeilingPricing.OptionalItemSpecsAndFinish = "Arktura Atmosphera Rise Ceiling";
samsungArkturaSC3CeilingPricing.SpecialtyPricingProposalPrice = 40000;
samsungArkturaSC3CeilingPricing.DoesThisVendorNeedItsOwnInstaller = false;

samsungArmstrongMetalWorksPricing.SpecialPricingDivision = "Armstrong Metalworks Ceiling";
samsungArmstrongMetalWorksPricing.OptionalSpecialPricingVendorName = "Kamco";
samsungArmstrongMetalWorksPricing.OptionalItemSpecsAndFinish = "AArmstrong Metsalworks - Wood look finish";
samsungArmstrongMetalWorksPricing.SpecialtyPricingProposalPrice = 40000;
samsungArmstrongMetalWorksPricing.DoesThisVendorNeedItsOwnInstaller = false;

