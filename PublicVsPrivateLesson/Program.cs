
using System;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.age = 0;
            f.Biome = "Desert";

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
        }
    }
}

//1. Currently the biome field and Biome property are public.
//In Program.cs, the field is directly accessed and set to "Desert", an invalid value.
//Run the code to see that “Desert” is the field’s value.

//3. Address the error by changing the code in Program.cs: use the property (Biome) instead of the field (biome).
//You’ll need to change code in two places in the file.
//What is printed to the console now?