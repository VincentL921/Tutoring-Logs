using System;

namespace ForEachLoop
{
    class Program

    //1. Now you want to create a To Do list to keep track of your tasks. Write an empty loop that will
    //iterate through each item in your @todo array.

    //2. Inside of the loop, call the @CreateTodoItem() method.

    {
        static void Main(string[] args)
        {
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

            foreach (string item in todo)
            {
                CreateTodoItem(item);
            }

        }

        static void CreateTodoItem(string item)
        {
            Console.WriteLine($"[] {item}");
        }
    }
}
