using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDevice.Models
{
    public class Drink
    {


        [JsonProperty("strDrink")]
        public string Name { get; set; }

        [JsonProperty("strAlcoholic")]
        public string Alcoholic { get; set; }

        [JsonProperty("strInstructions")]
        public string Instructions { get; set; }

        [JsonProperty("strDrinkThumb")]
        public string Image { get; set; }

        [JsonProperty("strIngredient1")]
        public string Ingredient1 { get; set; }

        [JsonProperty("strIngredient2")]
        public string Ingredient2 { get; set; }

        [JsonProperty("strIngredient3")]
        public string Ingredient3 { get; set; }

        [JsonProperty("strIngredient4")]
        public string Ingredient4 { get; set; }

        [JsonProperty("strIngredient5")]
        public string Ingredient5 { get; set; }

        [JsonProperty("strIngredient6")]
        public string Ingredient6 { get; set; }

        [JsonProperty("strIngredient7")]
        public string Ingredient7 { get; set; }

        [JsonProperty("strIngredient8")]
        public string Ingredient8 { get; set; }

        [JsonProperty("strIngredient9")]
        public string Ingredient9 { get; set; }

        [JsonProperty("strIngredient10")]
        public string Ingredient10 { get; set; }
    }
}
