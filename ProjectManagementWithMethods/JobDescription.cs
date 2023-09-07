using System;
using System.Text;

namespace ProjectManagementWithMethods
{
    public class JobDescription
    {
        //private variable at the class level, but private. 
        //  you might also see it called a private member variable
        //
        private string _jobDescription = string.Empty;
        public Company Company { get; set; }
        public JobLocation JobLocation { get; set; }
        public PaymentAndCompensation PaymentAndCompensation { get; set; }
        public JobQualifications JobQualifications { get; set; }

        public List<JobTasks> JobTasks { get; set; }

        private string StringBuilder { get; set; }

        #region Class Properties & Job Listing Methods

        //To make reusable, change hard coded string values like "Senior Project Manager" to use a variable passed in
        //  through the method.
        //public void PositionAndCompany()
        public void PositionAndCompany(string jobTitle, string companyName)
        {
            //this.Company.JobTitle = "Senior Project Manager";
            this.Company.JobTitle = jobTitle;
            //this.Company.CompanyName = "Gotham Drywall Inc";
            this.Company.CompanyName = companyName;
        }


        //public void CompanyAddress()
        public void CompanyAddress(string address, string city, string state, string zip ,bool isOnSite)
        {
            //this.JobLocation.StreetAddress = "244-250 Green Street";
            //this.JobLocation.City = "Brooklyn";
            //this.JobLocation.State = "NY";
            //this.JobLocation.Zip = 11222;
            //this.JobLocation.PositionOnSite = true;
            
            this.JobLocation.StreetAddress = address;
            this.JobLocation.City = city;
            this.JobLocation.State = state;
            this.JobLocation.Zip = zip;
            this.JobLocation.PositionOnSite = isOnSite;
        }


        
        public void Qualifications(string education, int experience, string skillsets, string communication, string technicals)
        {
            //this.JobQualifications.Education = "Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.";
            //this.JobQualifications.YearsOfExperience = 5;
            //this.JobQualifications.Skillsets = "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.";
            //this.JobQualifications.Communication = "Strong communication skills, both written and verbal.";
            //this.JobQualifications.TechnicalExperience = "Proficiency in construction management software, such as Procore-familiarity & Plexxis are a plus.";

            this.JobQualifications.Education = education;
            this.JobQualifications.YearsOfExperience = experience;
            this.JobQualifications.Skillsets = skillsets;
            this.JobQualifications.Communication = communication;
            this.JobQualifications.TechnicalExperience = technicals;
        }


        public void JobSalary(int salary, string bonus, int vacation, int pto, string insurance)
        {
            //this.PaymentAndCompensation.Salary = 120000;
            //this.PaymentAndCompensation.Bonus = "You will recieve 5% of profits made on all completed projects";
            //this.PaymentAndCompensation.Vacation = 21;
            //this.PaymentAndCompensation.PTO = 6;
            //this.PaymentAndCompensation.InsuranceBenefits = "Includes company provided Medical, Vision & Dental insurances.";

            this.PaymentAndCompensation.Salary = salary;
            this.PaymentAndCompensation.Bonus = bonus;
            this.PaymentAndCompensation.Vacation = vacation;
            this.PaymentAndCompensation.PTO = pto;
            this.PaymentAndCompensation.InsuranceBenefits = insurance;
        }


        public void Tasks(string name, string description)
        {
            this.JobTasks.
        }


        //public void JobListing()
        public void BuildJobListing()
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

            //Removed string result = builder.ToString();
            //Removed Console.WriteLine(result);
            //Idea here is that before you display the listing and save to file, you call .BuildJobListing() first.
            //
            _jobDescription = builder.ToString();
        }

        public void DisplayJobListing()
        {
            Console.WriteLine(_jobDescription);
        }

        //Make SaveJobListing return a string value which is the file path of what you've created.
        // ex: c:\temp\myjob.txt <- full file path
        //             myjob.txt <- just the filename
        public void SaveJobListing()
        {
            //TODO: Figure out how to write job description output to a file.
            //  Save it to a file called {job name}.txt
        }

        //TODO: Add another method to email the job description, should have 2 arguments to the method
        //  1 for email address to send to...meaning you could send to me, your mom, your borhters...whoever.
        //  1 parameter for the file path of the job description

        #endregion

        //public JobDescription()
        //{
        //}

        // Move object creation/instantation for properties of this object into the constructor to make reusability easier going forward.
        // On call, softwareEngineer object errored out because these properties were null, so instead of duplicating effort/code by having
        //  to set the same values over again, moving it to the constructor allows it to be set once and then be good for
        //  an infinite amount of job description
        public JobDescription()
        {
            this.Company = new Company();
            this.JobLocation = new JobLocation();
            this.JobQualifications = new JobQualifications();
            this.PaymentAndCompensation = new PaymentAndCompensation();
            this.JobTasks = new List<JobTasks>();
        }

    }
}


