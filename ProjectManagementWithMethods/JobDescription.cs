using System;
using System.Text;

namespace ProjectManagementWithMethods
{
    public class JobDescription
    {
        public Company Company { get; set; }
        public JobLocation JobLocation { get; set; }
        public PaymentAndCompensation PaymentAndCompensation { get; set; }
        public JobQualifications JobQualifications { get; set; }

        public List<JobTasks> JobTasks { get; set; }

        private string StringBuilder { get; set; }

        #region Class Properties & Job Listing Methods

        public void PositionAndCompany()
        {
            this.Company.JobTitle = "Senior Project Manager";
            this.Company.CompanyName = "Gotham Drywall Inc";
        }


        public void CompanyAddress()
        {
            this.JobLocation.StreetAddress = "244-250 Green Street";
            this.JobLocation.City = "Brooklyn";
            this.JobLocation.State = "NY";
            this.JobLocation.Zip = 11222;
            this.JobLocation.PositionOnSite = true;
        }


        public void Qualifications()
        {
            this.JobQualifications.Education = "Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.";
            this.JobQualifications.YearsOfExperience = 5;
            this.JobQualifications.Skillsets = "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.";
            this.JobQualifications.Communication = "Strong communication skills, both written and verbal.";
            this.JobQualifications.TechnicalExperience = "Proficiency in construction management software, such as Procore-familiarity & Plexxis are a plus.";
        }


        public void JobSalary()
        {
            this.PaymentAndCompensation.Salary = 120000;
            this.PaymentAndCompensation.Bonus = "You will recieve 5% of profits made on all completed projects";
            this.PaymentAndCompensation.Vacation = 21;
            this.PaymentAndCompensation.PTO = 6;
            this.PaymentAndCompensation.InsuranceBenefits = "Includes company provided Medical, Vision & Dental insurances.";
        }


        public void JobListing()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Job Listing:");
            builder.AppendLine($"Position Title: {this.Company.JobTitle}");
            builder.AppendLine($"Comapny Name: {this.Company.CompanyName}");
            builder.AppendLine($"Company Address: {this.JobLocation.StreetAddress}, {this.JobLocation.City} {this.JobLocation.State} {this.JobLocation.Zip}");
            if (this.JobLocation.PositionOnSite == true)
            {
                builder.AppendLine("This position requires you to be both on project sites & in the office.");
            }
            else
            {
                builder.AppendLine("This only requires you to be in the office only. No site visits are required.");
            }

            builder.AppendLine($"");

            builder.AppendLine($"Required Tasks for This Position:");
   
            foreach (var jitem in this.JobTasks)
            {
                builder.AppendLine($"- {jitem.NameOfTask}: {jitem.TaskDescription}");
            }

            builder.AppendLine($"");

            builder.AppendLine($"Job Qualifications:");
            builder.AppendLine($"- {this.JobQualifications.Education}");
            builder.AppendLine($"- {this.JobQualifications.YearsOfExperience} years of high rise construction experience is needed.");
            builder.AppendLine($"- {this.JobQualifications.Skillsets}");
            builder.AppendLine($"- {this.JobQualifications.Communication}");
            builder.AppendLine($"- {this.JobQualifications.TechnicalExperience}");

            builder.AppendLine($"");

            builder.AppendLine($"Payment & Compensation:");
            builder.AppendLine($"- Annual Salary: ${this.PaymentAndCompensation.Salary} per year.");
            builder.AppendLine($"- Bonus: {this.PaymentAndCompensation.Bonus}");
            builder.AppendLine($"- Vacation: {this.PaymentAndCompensation.Vacation} paid holidays.");
            builder.AppendLine($"- PTO: {this.PaymentAndCompensation.PTO} paid for sick/leave days.");
            builder.AppendLine($"- Insurance: {this.PaymentAndCompensation.InsuranceBenefits}");

            string result = builder.ToString();
            Console.WriteLine(result);
        }

        #endregion

        public JobDescription()
        {

        }

    }
}


