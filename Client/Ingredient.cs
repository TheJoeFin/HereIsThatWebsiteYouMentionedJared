using System.Collections.Generic;

namespace BlazorApp.Client
{
    public class Ingredient
    {
        public string Name { get; set; } = "";
        public int Parts { get; set; } = 1;

        public int TotalParts { get; set; }

        public double FinalOunces { get; set; }

        public int ID { get; set; }
    }
}
