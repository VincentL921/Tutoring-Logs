using System;
namespace JobsProposalClassesExercise
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

