using System;

namespace ElseIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = 3;

            if (guests >= 4)
            {
                //Catan will be played if 4 or more guests arrive
                Console.WriteLine("Catan");
            }
            else if (guests >= 1)
            {
                //Innovation will be played if 1 - 3 people arrive
                Console.WriteLine("Innovation");
            }
            else
            {
                //if both options are false & it's only you, play Solitaire
                Console.WriteLine("Solitaire");
            }


        }
    }
}


