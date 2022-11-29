using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDevice.Models
{
    public class OwnCocktail 
    {

        [JsonProperty("id")]
        public string Id { get; set; }

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



        public string AmountOfIngredients
        {
            get
            {

                List<string> ingredients = new List<string>();

                string in1 = Ingredient1;
                string in2 = Ingredient2;
                string in3 = Ingredient3;
                string in4 = Ingredient4;
                string in5 = Ingredient5;
                string in6 = Ingredient6;
                string in7 = Ingredient7;
                string in8 = Ingredient8;
                string in9 = Ingredient9;
                string in10 = Ingredient10;

                ingredients.Add(in1);
                ingredients.Add(in2);
                ingredients.Add(in3);
                ingredients.Add(in4);
                ingredients.Add(in5);
                ingredients.Add(in6);
                ingredients.Add(in7);
                ingredients.Add(in8);
                ingredients.Add(in9);
                ingredients.Add(in10);

                List<string> InAmount = new List<string>();


                foreach (string ingredient in ingredients)
                {
                    if (ingredient != null)
                    {
                        InAmount.Add(ingredient);
                    }
                }

                int result = InAmount.Count;

                return $"Amount of ingredients {result}";

            }

        }



    }
}
