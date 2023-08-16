using System;
namespace ProjectManagementWork
{
	public class JobDescription
	{
        public string JobTitle { get; set; }
		public string JobLocation { get; set; }
        public PaymentAndCompensation paymentAndCompensation { get; set; }
		public JobQualifications jobQualifications { get; set; }
		public DailyTasksOfJob dailyTasksOfJob { get; set; }

        public JobDescription()
		{
		}
	}
}

