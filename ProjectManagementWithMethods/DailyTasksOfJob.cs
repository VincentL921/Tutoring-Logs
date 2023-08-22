using System;
namespace ProjectManagementWithMethods
{
    public class DailyTasksOfJob
    {
        public string NameOfTask { get; set; }
        public string TaskDescription { get; set; }

        private List<string> AllowedDivisions { get; set; }

        public DailyTasksOfJob()
        {
            this.AllowedDivisions = new List<string>();
            this.AllowedDivisions.Add("Supporting The Project");
            this.AllowedDivisions.Add("Communication And Coordination");
            this.AllowedDivisions.Add("Documentation And Reporting");
            this.AllowedDivisions.Add("Risk Management");
            this.AllowedDivisions.Add("Bid Leveling");
            this.AllowedDivisions.Add("Cost Estimation");
            this.AllowedDivisions.Add("Pre-Con");
            this.AllowedDivisions.Add("Design Phase");
        }

        public void Build(string name, string description)
        {
            this.BuildTasks(name, description);
        }

        private void BuildTasks(string name, string description)
        {
            if (!this.AllowedDivisions.Contains(name))
            {
                throw new ArgumentException($"{name} is not an allowed task for this position.");
            }

            this.NameOfTask = name;
            this.TaskDescription = description;

        }
    }
}


