using System;

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
            f.Biome = "Tropical";

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
        }
    }
}

//3.
//In Program.cs,
//Replace any use of the field f.name with the property f.Name.
//Replace any use of the field f.trees with the property f.Trees.

//4. Define a Biome property for the biome field. It will have a getter and setter.
//The setter should only allow three values: "Tropical", "Temperate", and "Boreal".
//If any other value is used, set biome to "Unknown".