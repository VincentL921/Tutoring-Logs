
using System.Linq;
using ProjectManagementWork;

List<JobDescription> jobPosting = new List<JobDescription>();
var seniorProjectManager = new JobDescription();

//List<BidProposal> project = new List<BidProposal>();
//var samsungPennOne = new BidProposal();

seniorProjectManager.paymentAndCompensation = new PaymentAndCompensation();
seniorProjectManager.jobQualifications = new JobQualifications();
seniorProjectManager.dailyTasksOfJob = new DailyTasksOfJob();


seniorProjectManager.JobTitle = "Senior Project Manager";
seniorProjectManager.CompanyName = "Gotham Drywall Inc.";
seniorProjectManager.JobLocation = "Various Project Sites & 244-250 Green Street, Brooklyn NY 11222";

seniorProjectManager.paymentAndCompensation.Salary = 120000;
seniorProjectManager.paymentAndCompensation.Bonus = "You will recieve 10% of total profit made on projects you complete *going to come up with a formula for this one - VL*";
seniorProjectManager.paymentAndCompensation.Vacation = 21;
seniorProjectManager.paymentAndCompensation.PTO = 6;
seniorProjectManager.paymentAndCompensation.InsuranceAndBenefits = "Includes paid insurance choices of health, dental, vision etc";

seniorProjectManager.dailyTasksOfJob.SupportingTheProject = "You will assist the Director of Construction in various tasks, such as managing staff like inspectors, schedulers, estimators, and site safety personnel. Other tasks include coordinating and organizing project plans, scheduling meetings, allocating project resources, and monitoring construction schedule progress.";
seniorProjectManager.dailyTasksOfJob.CommunicationAndCoordination = "You will be responsible for facilitating communication between team members, architects, designers and engineers and all relevant trade disciplines. This includes organizing meetings, preparing meeting minutes on Procore and ensuring that everyone is informed about project updates and action items";
seniorProjectManager.dailyTasksOfJob.DocumentationAndReporting = "You will manage project documentation which includes project plans, requirements, and specifications and RFIs. You may also assist in preparing progress reports, status updates, and other project- related documentation.";
seniorProjectManager.dailyTasksOfJob.RiskManagement = "Risk Management: You will contribute to identifying and assessing project risk. You may assist in developing risk mitigation strategies and monitoring risks throughout the project lifecycle.";
seniorProjectManager.dailyTasksOfJob.BidLeveling = "You will help evaluate bid opportunities to determine their suitability, feasibility, and alignment with the company’s capabilities and resources. You will be the main point of contact for coordinating submittals of bid proposals and ensure that the proposal meets all the required specifications, and all scope of work is accounted for as per the specified set of plans.";
seniorProjectManager.dailyTasksOfJob.CostEstimation = "You may, from time to time, be responsible to quantify and estimate the quantities of materials needed for the project.";
seniorProjectManager.dailyTasksOfJob.PreCon = "You will collaborate in executing the pre-construction phase of a project with the assigned Preconstruction team. This includes conducting a thorough analysis to assess the design of the building as well as all the documentation and reports/surveys needs for this phase.";
seniorProjectManager.dailyTasksOfJob.DesignPhase = "You will be working with architects and engineers to refine the conceptual design of the drawings. You will also help ensure effective communication and coordination among all design disciplines including architects, engineers, and consultants.";


seniorProjectManager.jobQualifications.Education = "Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.";
seniorProjectManager.jobQualifications.YearsOfExperience = 5;
seniorProjectManager.jobQualifications.SkillsetsForPosition = "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.";
seniorProjectManager.jobQualifications.CommunicationExperience = "Strong communication skills, both written and verbal.";
seniorProjectManager.jobQualifications.TechnicalExperience = "Proficiency in construction management software, such as Procore-familiarity with project management tool Plexxis a plus.";


jobPosting.Add(seniorProjectManager);


foreach (var item in jobPosting)
{
    Console.WriteLine($"Construction Job Posting in NYC");
    Console.WriteLine($"Job Title: {item.JobTitle}");
    Console.WriteLine($"Company Name: {item.CompanyName}");
    Console.WriteLine($"Location of Work: {item.JobLocation}");

    Console.WriteLine("");

    Console.WriteLine("About The Job:");
    Console.WriteLine("");
    Console.WriteLine("Responsibilities:");
    Console.WriteLine($"- Supporting the Project: {item.dailyTasksOfJob.SupportingTheProject}");
    Console.WriteLine("");
    Console.WriteLine($"- Communication & Coordination: {item.dailyTasksOfJob.CommunicationAndCoordination}");
    Console.WriteLine("");
    Console.WriteLine($"- Documentation & Reporting: {item.dailyTasksOfJob.DocumentationAndReporting}");
    Console.WriteLine("");
    Console.WriteLine($"- Risk Management: {item.dailyTasksOfJob.RiskManagement}");
    Console.WriteLine("");
    Console.WriteLine($"- Bid Leveling: {item.dailyTasksOfJob.BidLeveling}");
    Console.WriteLine($"");
    Console.WriteLine($"- Cost Estimation: {item.dailyTasksOfJob.CostEstimation}");
    Console.WriteLine($"");
    Console.WriteLine($"- PreCon: {item.dailyTasksOfJob.PreCon}");
    Console.WriteLine($"");
    Console.WriteLine($"- Design Phase: {item.dailyTasksOfJob.DesignPhase}");

    Console.WriteLine($"");

    Console.WriteLine($"Qualifications:");
    Console.WriteLine($"- Education: {item.jobQualifications.Education}");
    Console.WriteLine($"- Experience: {item.jobQualifications.YearsOfExperience} or more years of high rise construction experience is needed.");
    Console.WriteLine($"- Demands of This Job: {item.jobQualifications.SkillsetsForPosition}");
    Console.WriteLine($"- Comminucation: {item.jobQualifications.CommunicationExperience}");
    Console.WriteLine($"- Techincal Proficiency: {item.jobQualifications.TechnicalExperience}");

    Console.WriteLine($"");

    Console.WriteLine($"Payment & Compensation:");
    Console.WriteLine($"Annual Salary: ${item.paymentAndCompensation.Salary}");
    Console.WriteLine($"Bonus: {item.paymentAndCompensation.Bonus}");
    Console.WriteLine($"Vacation: {item.paymentAndCompensation.Vacation} paid for vacation days.");
    Console.WriteLine($"PTO: {item.paymentAndCompensation.PTO} paid for sick/leave days.");


}


//Supporting the Project: You will assist the Director of Construction in various tasks, such as managing staff like inspectors, schedulers, estimators, and site safety personnel. Other tasks include coordinating and organizing project plans, scheduling meetings, allocating project resources, and monitoring construction schedule progress. 
//Communication and Coordination: You will be responsible for facilitating communication between team members, architects, designers and engineers and all relevant trade disciplines. This includes organizing meetings, preparing meeting minutes on Procore and ensuring that everyone is informed about project updates and action items. 
//Documentation and Reporting: You will manage project documentation which includes project plans, requirements, and specifications and RFIs. You may also assist in preparing progress reports, status updates, and other project- related documentation. 
//Risk Management: You will contribute to identifying and assessing project risk. You may assist in developing risk mitigation strategies and monitoring risks throughout the project lifecycle. 
//BID Leveling: You will help evaluate bid opportunities to determine their suitability, feasibility, and alignment with the company’s capabilities and resources. You will be the main point of contact for coordinating submittals of bid proposals and ensure that the proposal meets all the required specifications, and all scope of work is accounted for as per the specified set of plans.
//Takeoffs; Cost Estimation: You may, from time to time, be responsible to quantify and estimate the quantities of materials needed for the project.
//Pre-Con: You will collaborate in executing the pre-construction phase of a project with the assigned Preconstruction team. This includes conducting a thorough analysis to assess the design of the building as well as all the documentation and reports/surveys needs for this phase. 
//Design phase: You will be working with architects and engineers to refine the conceptual design of the drawings. You will also help ensure effective communication and coordination among all design disciplines including architects, engineers, and consultants.
//VL 8/15/23 - These job descriptions described the job best on linkedin. It's alot so going to trim it down once everything is set."