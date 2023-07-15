using System;
using BasicClasses;

namespace BasicClasses
{
    class Forest
    {
        public int age;
        private string biome;

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }
    }

}

//2. By directly accessing the public biome field the code skipped the validation.
//Let’s prevent that by setting the biome field to private in Forest.cs.
//When you run the code, you should see the error: CS022.
//That means C# has prevented us from accessing a private field (which is good).