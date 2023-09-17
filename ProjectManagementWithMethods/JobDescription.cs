using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ProjectManagementWithMethods
{
    public class JobDescription
    {
        //private variable at the class level, but private. 
        //  you might also see it called a private member variable
        //
        private string _jobDescription = string.Empty;
        public string FilePath { get; set; }
        public string ReturnPathString { get; set; }
        public Company Company { get; set; }
        public JobLocation JobLocation { get; set; }
        public PaymentAndCompensation PaymentAndCompensation { get; set; }
        public JobQualifications JobQualifications { get; set; }

        public List<JobTasks> JobTasks { get; set; }

        private string StringBuilder { get; set; }

        #region Class Properties & Job Listing Methods

        public void SetPositionAndCompany(string jobTitle, string companyName)
        {
            this.Company.JobTitle = jobTitle;
            this.Company.CompanyName = companyName;
        }

        public void SetCompanyAddress(string address, string city, string state, int zip ,bool isOnSite)
        {   
            this.JobLocation.StreetAddress = address;
            this.JobLocation.City = city;
            this.JobLocation.State = state;
            this.JobLocation.Zip = zip;
            this.JobLocation.PositionOnSite = isOnSite;
        }

        public void SetQualifications(string education, int experience, string skillsets, string communication, string technicals)
        {
            this.JobQualifications.Education = education;
            this.JobQualifications.YearsOfExperience = experience;
            this.JobQualifications.Skillsets = skillsets;
            this.JobQualifications.Communication = communication;
            this.JobQualifications.TechnicalExperience = technicals;
        }


        public void SetJobSalary(int salary, string bonus, int vacation, int pto, string insurance)
        {
            this.PaymentAndCompensation.Salary = salary;
            this.PaymentAndCompensation.Bonus = bonus;
            this.PaymentAndCompensation.Vacation = vacation;
            this.PaymentAndCompensation.PTO = pto;
            this.PaymentAndCompensation.InsuranceBenefits = insurance;
        }

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

            _jobDescription = builder.ToString();
        }

        public void DisplayJobListing()
        {
            Console.WriteLine(_jobDescription);
        }

        public string SaveJobListing(string pathName)
        {
            this.FilePath = pathName;
            File.WriteAllText(pathName, _jobDescription);

            return pathName;
        }

        public void EmailJobListing()
        {

            MailAddress to = new MailAddress("VincentL921@gmail.com");
            MailAddress from = new MailAddress("VincentL921@gmail.com");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing Out Email Sending";
            email.Body = "Attachment Testing";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("/Users/vincentlentini/Projects/ProjectManagementClassesWork/pmjoblisting.txt");
            email.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("l34rn2c0d3g00d@gmail.com", "pablzyzvvhybodrd");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            smtp.Send(email);

            try
            {
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //TODO: Add another method to email the job description, should have 2 arguments to the method
        //  1 for email address to send to...meaning you could send to me, your mom, your borhters...whoever.
        //  1 parameter for the file path of the job description

        #endregion

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


