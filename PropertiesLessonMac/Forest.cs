using System;

namespace BasicClasses
{
    class Forest
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int trees;
        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        }

        public int age;

        public string biome;
        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" || value == "Temperate" || value == "Boreal")
                {
                    biome = value;
                 }
                else { biome = "Unkonwn"; }
            }
        }

    }

}

//1. Define a basic Name property for the name field. The getter and setter will have no validation.
//2. Define a basic Trees property for the trees field. The getter and setter will have no validation.
