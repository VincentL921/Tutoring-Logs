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


samsungPennOne.JobBidInformation();
samsungPennOne.BaseBidPricing();




samsungActCeilingPricing.Build("David Inc",
    "Metro Interiors Constriction Supply",
    "USG Glacier 2\'x2\' ACT - White Finish - 15/16\" Donn Grid",
    150000,
    false);


//samsungHMDoorPricing.DoorSpecialtyPricing();
//samsungArkturaSC1CeilingPricing.ArkturaSC1SpecialPricing();
//samsungArkturaSC2CeilingPricing.ArkturaSC2SpecialPricing();
//samsungArkturaSC3CeilingPricing.ArkturaSC3SpecialPricing();
//samsungArmstrongMetalWorksPricing.ArmstrongMetalCeilingSpecialPricing();


//^^detailed backend info that goes into what is needed to back up and build an official proposal to present to the client.

samsungPennOne.SpecialPricingLineItems.Add(samsungHMDoorPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArmstrongMetalWorksPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC3CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC2CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungArkturaSC1CeilingPricing);
samsungPennOne.SpecialPricingLineItems.Add(samsungActCeilingPricing);

project.Add(samsungPennOne);

foreach (var item in project)
{
    item.DisplayProposal();
}

    //having trouble implementing it into the code now
    //DMW - 8/7/2023 - see notes i put on top of the DisplayProposal method in BidProposal class.

 var specialPriceTotal = (samsungHMDoorPricing.SpecialtyPricingProposalPrice +
    samsungArmstrongMetalWorksPricing.SpecialtyPricingProposalPrice +
    samsungArkturaSC3CeilingPricing.SpecialtyPricingProposalPrice +
    samsungArkturaSC2CeilingPricing.SpecialtyPricingProposalPrice +
    samsungArkturaSC1CeilingPricing.SpecialtyPricingProposalPrice +
    samsungActCeilingPricing.SpecialtyPricingProposalPrice);



int drywallTotalNotInForeachLoop = (samsungPennOne.FAndIDrywallPartitions +
    samsungPennOne.FAndIGypsumCeilingsAndSoffits +
    samsungPennOne.ProvidanceOfWallBlocking +
    samsungPennOne.ProvidanceOfCeilingBlocking +
    samsungPennOne.ProvidanceOfExistingWallPatching +
    samsungPennOne.ProvidanceOfExistingCeilingPatching +
    samsungPennOne.ProvideFramingForNotOurTradeCeilings +
    samsungPennOne.InstallBathroomAccessories +
    samsungPennOne.InstallDoorsFramesAndHardware);


Console.WriteLine($"Total for Additional Items: {specialPriceTotal}");
Console.WriteLine($"");
Console.WriteLine($"Overall Total: {drywallTotalNotInForeachLoop + specialPriceTotal}");

