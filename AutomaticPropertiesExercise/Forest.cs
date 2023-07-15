using System;

namespace BasicClasses
{
    class Forest
    {
        public int age;
        public string biome;

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

//1. Replace the current name field and Name property with an automatic Name property.
//2. Replace the current trees field and Trees property with an automatic Trees property.