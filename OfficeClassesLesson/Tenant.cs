using System;
namespace OfficeClassesLesson
{
	public class Tenant
	{
		public string Name { get; set; }
		public string Industry { get; set; }
		public string TenantType { get; set; }
		public List <Occupants> People { get; set; }

		public Tenant()
		{
		}
	}
}

