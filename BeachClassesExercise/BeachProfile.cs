using System;
namespace BeachClassesExercise
{
	public class BeachProfile
	{
		public string UsageType { get; set; }
		public string TypeOfBeach { get; set; }
		public BeachLocation Location { get; set; }
		//public BeachAreas Area { get; set; }
        public List<Pedestrians> People { get; set; }
        //public List<Pedestrians> People { get; set; }

        public BeachProfile()
		{
		}
	}
}

