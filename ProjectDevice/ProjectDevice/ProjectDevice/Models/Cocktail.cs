using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDevice.Models
{
    public class Cocktail
    {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Instructions { get; set; }
            public string Image { get; set; }
            public Ingredient Ingredients { get; set; }
    }
    public class Ingredient
    {
        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }
        public string Ingredient3 { get; set; }
        public string Ingredient4 { get; set; }
        public string Ingredient5 { get; set; }
        public string Ingredient6 { get; set; }
        public string Ingredient7 { get; set; }
        public string Ingredient8 { get; set; }
        public string Ingredient9 { get; set; }
        public string Ingredient10 { get; set; }
    }
}
