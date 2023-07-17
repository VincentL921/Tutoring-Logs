////This for loop method was the incorrect answer that I initially gave. Below is the correct foreach loop method answer.
//using System;
//using System.ComponentModel;

//namespace ComparingLoops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] websites = { "twitter", "facebook", "gmail" };
            

//            for (int i = 0;  i < websites.Length; i++)
//      {
//                Console.WriteLine(websites[i]);
//            }
//        }
//    }
//}


////This is the correct answer in foreach method
////1. You want to build an app that blocks websites, so you find some code online and copy and paste it into your text editor.
////You notice that it uses a while loop to iterate through a websites array, but you know a better way to do that!
////Re - write the loop so that it uses a loop that better suits the objective.

//using System;

//namespace ComparingLoops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] websites = { "twitter", "facebook", "gmail" };

//            foreach (string app in websites)
//            {
//                Console.WriteLine(app);
//            }
//        }
//    }
//}

////This was the original while loop method that needed to be changed for the exercise

//using System;

//namespace ComparingLoops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] websites = { "twitter", "facebook", "gmail" };
//            int counter = 0;

//            while (counter < websites.Length)
//            {
//                Console.WriteLine(websites[counter]);
//                counter++;
//            }
//        }
//    }
//}

