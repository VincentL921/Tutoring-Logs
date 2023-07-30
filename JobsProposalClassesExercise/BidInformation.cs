using System;
namespace JobsProposalClassesExercise
{
	public class BidInformation
	{
		public string ProjectName { get; set; }
        public string ProjectClient { get; set; }
        public string TypeOfConstruction { get; set; }
        public string TodaysDate { get; set; }
        public string VersionOfBid { get; set; }
        public string BluePrintAddendum { get; set; }
        public string BluePrintDates { get; set; }

        public BidInformation()
		{
		}
	}
}

