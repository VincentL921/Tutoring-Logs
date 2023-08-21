using System;
namespace ProjectManagementWork
{
	public class JobDescription
	{ 
        public Company Company { get; set; }
		public JobLocation JobLocation { get; set; }
        public PaymentAndCompensation PaymentAndCompensation { get; set; }
		public JobQualifications JobQualifications { get; set; }

        public List<DailyTasksOfJob> DailyTasksOfJob { get; set; }

        public JobDescription()
		{
        }
	}
}

