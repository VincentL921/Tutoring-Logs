using System;
namespace RestaurantMenuWithClassesProject
{
	public class Menu
	{
		//Change from single  menu item per menu to a collection so we can have however many items are on the menu under one menu rather
		//	than one menu per item.
		//public string MenuItems { get; set; }
        public List<string> MenuItems { get; set; }
        //public int ItemNumbers { get; set; }
        //Renamed ItemNumbers to selected items so we can collect all of the users selections in one spot on the menu.
        public List<int> SelectedItems { get; set; }
        public int ItemNumbers { get; set; }
        public string Input { get; set; }
		public int InputAsInt { get; set; }
		public int IndexOfItems { get; set; }

        public Menu()
		{
		}
	}
}

