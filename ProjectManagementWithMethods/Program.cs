
using System.Linq;
using ProjectManagementWithMethods;

List<JobDescription> jobPosting = new List<JobDescription>();
var seniorProjectManager = new JobDescription();

seniorProjectManager.Company = new Company();
seniorProjectManager.JobLocation = new JobLocation();
seniorProjectManager.JobQualifications = new JobQualifications();
seniorProjectManager.PaymentAndCompensation = new PaymentAndCompensation();

seniorProjectManager.DailyTasksOfJob = new List<DailyTasksOfJob>();
var supportingTheProject = new DailyTasksOfJob();
var communicationAndCoordination = new DailyTasksOfJob();
var documentationAndReporting = new DailyTasksOfJob();
var riskManagement = new DailyTasksOfJob();
var bidLeveling = new DailyTasksOfJob();
var costEstimation = new DailyTasksOfJob();
var preConstruction = new DailyTasksOfJob();
var designPhase = new DailyTasksOfJob();

seniorProjectManager.Company.JobTitle = "Senior Project Manager";
seniorProjectManager.Company.CompanyName = "Gotham Drywall Inc";

seniorProjectManager.JobLocation.StreetAddress = "244-250 Green Street";
seniorProjectManager.JobLocation.City = "Brooklyn";
seniorProjectManager.JobLocation.State = "NY";
seniorProjectManager.JobLocation.Zip = 11222;
seniorProjectManager.JobLocation.DoesThisPositionGoOnSite = true;

seniorProjectManager.JobQualifications.Education = "Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.";
seniorProjectManager.JobQualifications.YearsOfExperience = 5;
seniorProjectManager.JobQualifications.SkillsetsForPosition = "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.";
seniorProjectManager.JobQualifications.CommunicationExperience = "Strong communication skills, both written and verbal.";
seniorProjectManager.JobQualifications.TechnicalExperience = "Proficiency in construction management software, such as Procore-familiarity & Plexxis are a plus.";

seniorProjectManager.PaymentAndCompensation.Salary = 120000;
seniorProjectManager.PaymentAndCompensation.Bonus = "You will recieve 5% of profits made on all completed projects";
seniorProjectManager.PaymentAndCompensation.Vacation = 21;
seniorProjectManager.PaymentAndCompensation.PTO = 6;
seniorProjectManager.PaymentAndCompensation.InsuranceAndBenefits = "Includes company provided Medical, Vision & Dental insurances.";

supportingTheProject.NameOfTask = "Supporting The Project";
supportingTheProject.TaskDescription = "You will assist the Director of Construction in various tasks, such as managing staff like inspectors, schedulers, estimators, and site safety personnel. Other tasks include coordinating and organizing project plans, scheduling meetings, allocating project resources, and monitoring construction schedule progress.";

communicationAndCoordination.NameOfTask = "Communication And Coordination";
communicationAndCoordination.TaskDescription = "You will be responsible for facilitating communication between team members, architects, designers and engineers and all relevant trade disciplines.";

documentationAndReporting.NameOfTask = "Documentation And Reporting";
documentationAndReporting.TaskDescription = "You will manage project documentation which includes project plans, requirements, and specifications and RFIs. You may also assist in preparing progress reports, status updates, and other project- related documentation.";

riskManagement.NameOfTask = "Risk Management";
riskManagement.TaskDescription = "You will contribute to identifying and assessing project risk. You may assist in developing risk mitigation strategies and monitoring risks throughout the project lifecycle.";

bidLeveling.NameOfTask = "Bid Leveling";
bidLeveling.TaskDescription = "You will help evaluate bid opportunities to determine their suitability, feasibility, and alignment with the company’s capabilities and resources. You will also be responsible to level/compare the incoming proposals per trade.";

costEstimation.NameOfTask = "Cost Estimation";
costEstimation.TaskDescription = "You may, from time to time, be responsible to quantify and estimate the quantities of materials needed for the project.";

preConstruction.NameOfTask = "Pre-Con";
preConstruction.TaskDescription = "You will collaborate in executing the pre-construction phase of a project with the assigned Preconstruction team.";

designPhase.NameOfTask = "Design Phase";
designPhase.TaskDescription = "You will be working with architects and engineers to refine the conceptual design of the drawings. You will also help ensure effective communication among all design disciplines including architects, engineers, and consultants.";


jobPosting.Add(seniorProjectManager);

seniorProjectManager.DailyTasksOfJob.Add(supportingTheProject);
seniorProjectManager.DailyTasksOfJob.Add(communicationAndCoordination);
seniorProjectManager.DailyTasksOfJob.Add(documentationAndReporting);
seniorProjectManager.DailyTasksOfJob.Add(riskManagement);
seniorProjectManager.DailyTasksOfJob.Add(bidLeveling);
seniorProjectManager.DailyTasksOfJob.Add(costEstimation);
seniorProjectManager.DailyTasksOfJob.Add(preConstruction);
seniorProjectManager.DailyTasksOfJob.Add(designPhase);


foreach (var item in jobPosting)
{
    Console.WriteLine($"Job Listing:");
    Console.WriteLine($"Position Title: {item.Company.JobTitle}");
    Console.WriteLine($"Comapny Name: {item.Company.CompanyName}");
    Console.WriteLine($"Company Address: {item.JobLocation.StreetAddress}, {item.JobLocation.City} {item.JobLocation.State} {item.JobLocation.Zip}");
    if (item.JobLocation.DoesThisPositionGoOnSite == true)
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
    foreach (var jitem in item.DailyTasksOfJob)
    {
        Console.WriteLine($"- {jitem.NameOfTask}: {jitem.TaskDescription}");
        indexForDailyTasksLoop++;
    }

    Console.WriteLine($"");

    Console.WriteLine($"Job Qualifications:");
    Console.WriteLine($"- {item.JobQualifications.Education}");
    Console.WriteLine($"- {item.JobQualifications.YearsOfExperience} years of high rise construction experience is needed.");
    Console.WriteLine($"- {item.JobQualifications.SkillsetsForPosition}");
    Console.WriteLine($"- {item.JobQualifications.CommunicationExperience}");
    Console.WriteLine($"- {item.JobQualifications.TechnicalExperience}");

    Console.WriteLine($"");

    Console.WriteLine($"Payment & Compensation:");
    Console.WriteLine($"- Annual Salary: ${item.PaymentAndCompensation.Salary} per year.");
    Console.WriteLine($"- Bonus: {item.PaymentAndCompensation.Bonus}");
    Console.WriteLine($"- Vacation: {item.PaymentAndCompensation.Vacation} paid holidays.");
    Console.WriteLine($"- PTO: {item.PaymentAndCompensation.PTO} paid for sick/leave days.");
    Console.WriteLine($"- Insurance: {item.PaymentAndCompensation.InsuranceAndBenefits}");
}

