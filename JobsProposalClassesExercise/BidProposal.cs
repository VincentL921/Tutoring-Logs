using System;
namespace JobsProposalClassesExercise
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

		public BidInformation bidInformation { get; set;}
		public List <ProposalSpecialtyPricing> SpecialPricingLineItems { get; set; }

		public BidProposal()
		{
		}
	}
}

