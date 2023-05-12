using System;
using System.ComponentModel;
using System.Text;

namespace ForLoop
{
    class Program
    {
        //For your next tool, you want to create a template for your weekly team meeting.
        //Rather than clone a new one each week, you decide to make all of them at once.

        //1. Write an empty for loop that runs once for each week in your 16-week long project.

        //2. Inside of the loop, call the CreateTemplate() method.It takes a number as a parameter that represents what week
        //it is within the project so that when the template is generated it will say Week X at the top,
        //with X representing which week it is.

        static void Main(string[] args)
        {
            for (int i = 1; i < 17; i++)
            {
                CreateTemplate(i);
            }

        }

        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }




    }
}
