using System;
namespace ProjectManagementWithMethods
{
    public class JobDescription
    {
        public Company Company { get; set; }
        public JobLocation JobLocation { get; set; }
        public PaymentAndCompensation PaymentAndCompensation { get; set; }
        public JobQualifications JobQualifications { get; set; }

        public List<DailyTasksOfJob> DailyTasksOfJob { get; set; }

        #region Class Properties & Job Listing Methods

        public void JobTitleAndCompanyName()
        {
            this.Company.JobTitle = "Senior Project Manager";
            this.Company.CompanyName = "Gotham Drywall Inc";
        }


        public void CompanyAddressAndOnSiteBool()
        {
            this.JobLocation.StreetAddress = "244-250 Green Street";
            this.JobLocation.City = "Brooklyn";
            this.JobLocation.State = "NY";
            this.JobLocation.Zip = 11222;
            this.JobLocation.DoesThisPositionGoOnSite = true;
        }


        public void PositionQualifications()
        {
            this.JobQualifications.Education = "Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.";
            this.JobQualifications.YearsOfExperience = 5;
            this.JobQualifications.SkillsetsForPosition = "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.";
            this.JobQualifications.CommunicationExperience = "Strong communication skills, both written and verbal.";
            this.JobQualifications.TechnicalExperience = "Proficiency in construction management software, such as Procore-familiarity & Plexxis are a plus.";
        }


        public void PayAndCompInfo()
        {
            this.PaymentAndCompensation.Salary = 120000;
            this.PaymentAndCompensation.Bonus = "You will recieve 5% of profits made on all completed projects";
            this.PaymentAndCompensation.Vacation = 21;
            this.PaymentAndCompensation.PTO = 6;
            this.PaymentAndCompensation.InsuranceAndBenefits = "Includes company provided Medical, Vision & Dental insurances.";
        }


        public void JobListing()
        {
            Console.WriteLine($"Job Listing:");
            Console.WriteLine($"Position Title: {this.Company.JobTitle}");
            Console.WriteLine($"Comapny Name: {this.Company.CompanyName}");
            Console.WriteLine($"Company Address: {this.JobLocation.StreetAddress}, {this.JobLocation.City} {this.JobLocation.State} {this.JobLocation.Zip}");
            if (this.JobLocation.DoesThisPositionGoOnSite == true)
            {
                Console.WriteLine("This position requires you to be both on project sites & in the office.");
            }
            else
            {
                Console.WriteLine("This only requires you to be in the office only. No site visits are required.");
            }

            Console.WriteLine($"");

            Console.WriteLine($"Required Tasks for This Position:");
            var indexForDailyTasksLoop = 1;
            foreach (var jitem in this.DailyTasksOfJob)
            {
                Console.WriteLine($"- {jitem.NameOfTask}: {jitem.TaskDescription}");
                indexForDailyTasksLoop++;
            }

            Console.WriteLine($"");

            Console.WriteLine($"Job Qualifications:");
            Console.WriteLine($"- {this.JobQualifications.Education}");
            Console.WriteLine($"- {this.JobQualifications.YearsOfExperience} years of high rise construction experience is needed.");
            Console.WriteLine($"- {this.JobQualifications.SkillsetsForPosition}");
            Console.WriteLine($"- {this.JobQualifications.CommunicationExperience}");
            Console.WriteLine($"- {this.JobQualifications.TechnicalExperience}");

            Console.WriteLine($"");

            Console.WriteLine($"Payment & Compensation:");
            Console.WriteLine($"- Annual Salary: ${this.PaymentAndCompensation.Salary} per year.");
            Console.WriteLine($"- Bonus: {this.PaymentAndCompensation.Bonus}");
            Console.WriteLine($"- Vacation: {this.PaymentAndCompensation.Vacation} paid holidays.");
            Console.WriteLine($"- PTO: {this.PaymentAndCompensation.PTO} paid for sick/leave days.");
            Console.WriteLine($"- Insurance: {this.PaymentAndCompensation.InsuranceAndBenefits}");
        }

        #endregion

        public JobDescription()
        {
        }
    }
}


