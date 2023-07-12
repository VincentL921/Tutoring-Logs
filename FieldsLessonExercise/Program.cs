using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.name = "Amazon";
            Console.WriteLine(f.name);

            
            f.biome = "rainforest";
            Console.WriteLine(f.biome);

            
            f.trees = 16000;
            Console.WriteLine(f.trees);

            
            f.age = 2000;
            Console.WriteLine(f.age);

            // Console.WriteLine(f.name);
            // Console.WriteLine(f.biome);
            // Console.WriteLine(f.trees);
            // Console.WriteLine(f.age);
        }
    }
}

//2. In Program.cs in Main(), a Forest object has already been instantiated. Set values to those four fields.
//3. In Main(), print the name field to the console.

