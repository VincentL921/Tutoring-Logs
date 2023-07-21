using System;
namespace OfficeClassesLesson
{
	public class Building
	{
		public string UsageType { get; set; }
		public string BuildingType { get; set; }
		public Tenant Tenant { get; set; }
		public Location Location { get; set; }

		public Building()
		{
		}
	}
}

