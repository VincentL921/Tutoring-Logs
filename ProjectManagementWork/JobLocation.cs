﻿using System;
namespace ProjectManagementWork
{
	public class JobLocation
	{
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
        public bool DoesThisPositionGoOnSite { get; set; }

		public JobLocation()
		{
		}
	}
}

