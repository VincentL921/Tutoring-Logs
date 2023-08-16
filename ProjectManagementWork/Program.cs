using System.Collections.Generic;
using System.Linq;
using ProjectManagementWork;

List<JobDescription> jobPosting = new List<JobDescription>();
var seniorProjectManager = new JobDescription();

seniorProjectManager.paymentAndCompensation = new PaymentAndCompensation();
seniorProjectManager.jobQualifications = new JobQualifications();
seniorProjectManager.dailyTasksOfJob = new DailyTasksOfJob();



seniorProjectManager.JobTitle = "Senior Project Manager";
seniorProjectManager.JobLocation = "244-250 Green Street, Brooklyn NY 11222";

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


//Supporting the Project: You will assist the Director of Construction in various tasks, such as managing staff like inspectors, schedulers, estimators, and site safety personnel. Other tasks include coordinating and organizing project plans, scheduling meetings, allocating project resources, and monitoring construction schedule progress. 
//Communication and Coordination: You will be responsible for facilitating communication between team members, architects, designers and engineers and all relevant trade disciplines. This includes organizing meetings, preparing meeting minutes on Procore and ensuring that everyone is informed about project updates and action items. 
//Documentation and Reporting: You will manage project documentation which includes project plans, requirements, and specifications and RFIs. You may also assist in preparing progress reports, status updates, and other project- related documentation. 
//Risk Management: You will contribute to identifying and assessing project risk. You may assist in developing risk mitigation strategies and monitoring risks throughout the project lifecycle. 
//BID Leveling: You will help evaluate bid opportunities to determine their suitability, feasibility, and alignment with the company’s capabilities and resources. You will be the main point of contact for coordinating submittals of bid proposals and ensure that the proposal meets all the required specifications, and all scope of work is accounted for as per the specified set of plans.
//Takeoffs; Cost Estimation: You may, from time to time, be responsible to quantify and estimate the quantities of materials needed for the project.
//Pre-Con: You will collaborate in executing the pre-construction phase of a project with the assigned Preconstruction team. This includes conducting a thorough analysis to assess the design of the building as well as all the documentation and reports/surveys needs for this phase. 
//Design phase: You will be working with architects and engineers to refine the conceptual design of the drawings. You will also help ensure effective communication and coordination among all design disciplines including architects, engineers, and consultants.
//VL 8/15/23 - These job descriptions described the job best on linkedin. It's alot so going to trim it down once everything is set."