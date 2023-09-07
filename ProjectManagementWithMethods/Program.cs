﻿
using System.Linq;
using System.Text;
using ProjectManagementWithMethods;

List<JobDescription> jobPosting = new List<JobDescription>();
var seniorProjectManager = new JobDescription();
var softwareEngineer = new JobDescription();

//seniorProjectManager.Company = new Company();
//seniorProjectManager.JobLocation = new JobLocation();
//seniorProjectManager.JobQualifications = new JobQualifications();
//seniorProjectManager.PaymentAndCompensation = new PaymentAndCompensation();

seniorProjectManager.JobTasks = new List<JobTasks>();
var supportingTheProject = new JobTasks();
var communicationAndCoordination = new JobTasks();
var documentationAndReporting = new JobTasks();
var riskManagement = new JobTasks();
var bidLeveling = new JobTasks();
var costEstimation = new JobTasks();
var preConstruction = new JobTasks();
var designPhase = new JobTasks();

//StringBuilder practice
//StringBuilder builder = new StringBuilder();

#region Class Properties
//seniorProjectManager.PositionAndCompany();
seniorProjectManager.PositionAndCompany("Senior Project Manager", "Gotham Drywall LLC");
softwareEngineer.PositionAndCompany("Senior Software Engineer", "Code Blocks LLC");


//seniorProjectManager.CompanyAddress();
seniorProjectManager.CompanyAddress("", "", "", "", true);

seniorProjectManager.Qualifications();
seniorProjectManager.JobSalary();

supportingTheProject.Build("Supporting The Project",
    "You will assist the Director of Construction in various tasks, such as managing staff like inspectors, schedulers, estimators, and site safety personnel. Other tasks include coordinating and organizing project plans, scheduling meetings, allocating project resources, and monitoring construction schedule progress.");

communicationAndCoordination.Build("Communication And Coordination",
    "You will be responsible for facilitating communication between team members, architects, designers and engineers and all relevant trade disciplines.");

documentationAndReporting.Build("Documentation And Reporting",
    "You will manage project documentation which includes project plans, requirements, and specifications and RFIs. You may also assist in preparing progress reports, status updates, and other project- related documentation.");

riskManagement.Build("Risk Management",
    "You will contribute to identifying and assessing project risk. You may assist in developing risk mitigation strategies and monitoring risks throughout the project lifecycle.");

bidLeveling.Build("Bid Leveling",
    "You will help evaluate bid opportunities to determine their suitability, feasibility, and alignment with the company’s capabilities and resources. You will also be responsible to level/compare the incoming proposals per trade.");

costEstimation.Build("Cost Estimation",
    "You may, from time to time, be responsible to quantify and estimate the quantities of materials needed for the project.");

preConstruction.Build("Pre-Con",
    "You will collaborate in executing the pre-construction phase of a project with the assigned Preconstruction team.");

designPhase.Build("Design Phase",
    "You will be working with architects and engineers to refine the conceptual design of the drawings. You will also help ensure effective communication among all design disciplines including architects, engineers, and consultants.");
#endregion

// Do all the "manipulations" to the object before adding to a main/primary collection like job posting.
// meaning, set all the proeprties/values to the object, add all items to the collections that are properties
//      within the object before adding it to the main collection.
//      In this case that main collection is jobPosting.
//
//jobPosting.Add(seniorProjectManager);
seniorProjectManager.JobTasks.Add(supportingTheProject);
seniorProjectManager.JobTasks.Add(communicationAndCoordination);
seniorProjectManager.JobTasks.Add(documentationAndReporting);
seniorProjectManager.JobTasks.Add(riskManagement);
seniorProjectManager.JobTasks.Add(bidLeveling);
seniorProjectManager.JobTasks.Add(costEstimation);
seniorProjectManager.JobTasks.Add(preConstruction);
seniorProjectManager.JobTasks.Add(designPhase);



//Added software engineer object to collection to demonstrate reusability.
jobPosting.Add(softwareEngineer);
jobPosting.Add(seniorProjectManager);

foreach (var item in jobPosting)
{
    item.JobListing();
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine(Environment.NewLine);
}
