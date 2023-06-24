using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LastNameBruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Vincent", "Dave", "Giovanni", "Justin", "Sarah", "George", "Vito", "Thomas", "Charles", "Ana" };
            string[] lastNames = { "Lentini", "Wimbley", "Rocco", "Lentini", "McGurn", "Prezioso", "Lentini", "Li", "Schmidt", "Lentini" };
            bool[] names = new bool[firstNames.Length];
            string nameToFind = "Lentini";

            var siblingLastName = Array.Find(lastNames, element => element.Contains(nameToFind));

            for (int i = 0; i < lastNames.Length; i++)
            {
                string personNames = firstNames[i];
                bool doTheyHaveSiblings = names[i];

                if (siblingLastName == nameToFind)
                {
                    Console.WriteLine("This person has siblings");
                }
                else if(siblingLastName != nameToFind)
                {
                    Console.WriteLine("This person does not have siblings");
                }

                }
            }


            //foreach (string title in siblingLastName)
            //{
                //Console.WriteLine(title);
           //}

        }
    }