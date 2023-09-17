
using System.Linq;
using System.Text;
using ProjectManagementWithMethods;

List<JobDescription> jobPosting = new List<JobDescription>();
var seniorProjectManager = new JobDescription();
var softwareEngineer = new JobDescription();
var pmFilePath = new JobDescription();

seniorProjectManager.JobTasks = new List<JobTasks>();
var supportingTheProject = new JobTasks();
var communicationAndCoordination = new JobTasks();
var documentationAndReporting = new JobTasks();
var riskManagement = new JobTasks();
var bidLeveling = new JobTasks();
var costEstimation = new JobTasks();
var preConstruction = new JobTasks();
var designPhase = new JobTasks();

#region Class Properties
seniorProjectManager.SetPositionAndCompany("Senior Project Manager", "Gotham Drywall LLC");
//softwareEngineer.PositionAndCompany("Senior Software Engineer", "Code Blocks LLC");
//Just focusing on PM coding right now VL 9/10/2023

seniorProjectManager.SetCompanyAddress("244-250 Greebn Street", "Brooklyn", "New York", 11222, true);

seniorProjectManager.SetQualifications("Bachelor’s degree in a relevant field such as project management, business administration, engineering, and /or construction management.",
    5,
    "Experience in coordinating project activities, assisting the Director of Construction or Senior Project Manager, and collaborate cross- functionally with departments to execute the vision of the project. Ability to manage multiple projects and their tasks, milestones and deliverables.",
    "Strong communication skills, both written and verbal.",
    "Proficiency in construction management software, such as Procore-familiarity & Plexxis are a plus.");

seniorProjectManager.SetJobSalary(120000, "You will recieve 5% of profits made on all completed projects", 21, 6, "Includes company provided Medical, Vision & Dental insurances.");

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

seniorProjectManager.SaveJobListing(@"/Users/vincentlentini/Projects/ProjectManagementClassesWork/pmjoblisting.txt");
seniorProjectManager.EmailJobListing();

seniorProjectManager.JobTasks.Add(supportingTheProject);
seniorProjectManager.JobTasks.Add(communicationAndCoordination);
seniorProjectManager.JobTasks.Add(documentationAndReporting);
seniorProjectManager.JobTasks.Add(riskManagement);
seniorProjectManager.JobTasks.Add(bidLeveling);
seniorProjectManager.JobTasks.Add(costEstimation);
seniorProjectManager.JobTasks.Add(preConstruction);
seniorProjectManager.JobTasks.Add(designPhase);

//jobPosting.Add(softwareEngineer);
jobPosting.Add(seniorProjectManager);
jobPosting.Add(pmFilePath);

foreach (var item in jobPosting)
{
    item.BuildJobListing();
    item.DisplayJobListing();
    item.SaveJobListing();
    item.EmailJobListing();
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine(Environment.NewLine);
}

