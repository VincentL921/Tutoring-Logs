using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenuWithClassesProject
{
    public class CondensedProgram_DONTRUNTHIS_REFERENCEONLY
    {
        public void CodeInLine()
        {
            var m1 = new Menu();
            m1.MenuItems = new List<string>();
            m1.SelectedItems = new List<int>();


            m1.MenuItems.Add("Pizza");
            m1.MenuItems.Add("Pasta");
            m1.MenuItems.Add("Chicken Parm");
            m1.MenuItems.Add("Meatballs");
            m1.MenuItems.Add("Soda");
            m1.MenuItems.Add("Chicken Carbonara");
            
            Console.WriteLine("Welcome to Vin's Pizza!");
            Console.WriteLine($"Please Begin Order:");

            #region Block of code can be moved to DisplayMenu method
            
            var counter = 1;
            foreach (var item in m1.MenuItems)
            {
                Console.WriteLine($"#{counter} - {item}");

                counter++;
            }
            
            #endregion

            int indexOfItems = 0;

            string menuInput = "";

            while (menuInput != "EXIT")
            {
                Console.WriteLine("What would you like?");
                menuInput = Console.ReadLine();
                
                #region Code could be moved to a PlaceOrder method
                
                bool isInteger = int.TryParse(menuInput, out int inputAsInt);

                while (menuInput != "EXIT" && ((inputAsInt == 0) || (inputAsInt > m1.MenuItems.Count) || (!isInteger && menuInput != "EXIT")))
                {
                    Console.WriteLine("Invalid Order. Please order a food item within range:");
                    menuInput = Console.ReadLine();
                    isInteger = int.TryParse(menuInput, out inputAsInt);
                }

                m1.SelectedItems.Add(inputAsInt);

                #endregion

                #region Code could be moved to a DisplaySelections method or DisplayMenuSelections method

                foreach (var item in m1.SelectedItems)
                {
                    if (item == 0)
                    {
                        continue;
                    }

                    var selectedItemNumber = item - 1;
                    var translationOfUserInput = m1.MenuItems[selectedItemNumber];
                    Console.WriteLine($"Your order: {translationOfUserInput}!");
                }

                #endregion

                Console.WriteLine("Thank you for your order. Please press Enter to checkout/continue!");
            }
        }

        public void UsingMethods()
        {
            var m1 = new Menu();
            m1.MenuItems = new List<string>();
            m1.SelectedItems = new List<int>();


            m1.MenuItems.Add("Pizza");
            m1.MenuItems.Add("Pasta");
            m1.MenuItems.Add("Chicken Parm");
            m1.MenuItems.Add("Meatballs");
            m1.MenuItems.Add("Soda");
            m1.MenuItems.Add("Chicken Carbonara");
            
            Console.WriteLine("Welcome to Vin's Pizza!");
            Console.WriteLine($"Please Begin Order:");
            
            m1.DisplayMenu();
      
            string menuInput = "";

            while (menuInput != "EXIT")
            {
                Console.WriteLine("What would you like?");
                menuInput = Console.ReadLine();

                m1.PlaceOrder(menuInput);
                m1.DisplaySelections();

                Console.WriteLine("Thank you for your order. Please press Enter to checkout/continue!");
            }
        }
    }
}
