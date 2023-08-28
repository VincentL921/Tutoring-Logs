
using System.Linq;
using System.Text;
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

//StringBuilder practice
//StringBuilder builder = new StringBuilder();

#region Class Properties
seniorProjectManager.JobTitleAndCompanyName();
seniorProjectManager.CompanyAddressAndOnSiteBool();
seniorProjectManager.PositionQualifications();
seniorProjectManager.PayAndCompInfo();

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
    item.JobListing();
}

