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
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alcoholic")]
        public bool Alcoholic { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("ingredient1")]
        public string Ingredient1 { get; set; }

        [JsonProperty("ingredient1-amount")]
        public string Ingredient1Amount { get; set; }

        [JsonProperty("ingredient2")]
        public string Ingredient2 { get; set; }

        [JsonProperty("ingredient2-amount")]
        public string Ingredient2Amount { get; set; }

        [JsonProperty("ingredient3")]
        public string Ingredient3 { get; set; }

        [JsonProperty("ingredient3-amount")]
        public string Ingredient3Amount { get; set; }

        [JsonProperty("ingredient4")]
        public string Ingredient4 { get; set; }

        [JsonProperty("ingredient4-amount")]
        public string Ingredient4Amount { get; set; }

        [JsonProperty("ingredient5")]
        public string Ingredient5 { get; set; }

        [JsonProperty("ingredient5-amount")]
        public string Ingredient5Amount { get; set; }

        [JsonProperty("ingredient6")]
        public string Ingredient6 { get; set; }

        [JsonProperty("ingredient6-amount")]
        public string Ingredient6Amount { get; set; }

        [JsonProperty("ingredient7")]
        public string Ingredient7 { get; set; }

        [JsonProperty("ingredient7-amount")]
        public string Ingredient7Amount { get; set; }

        [JsonProperty("ingredient8")]
        public string Ingredient8 { get; set; }

        [JsonProperty("ingredient8-amount")]
        public string Ingredient8Amount { get; set; }

        [JsonProperty("ingredient9")]
        public string Ingredient9 { get; set; }

        [JsonProperty("ingredient9-amount")]
        public string Ingredient9Amount { get; set; }

        [JsonProperty("ingredient10")]
        public string Ingredient10 { get; set; }

        [JsonProperty("ingredient10-amount")]
        public string Ingredient10Amount { get; set; }

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


                foreach(string ingredient in ingredients)
                {
                    if(ingredient != null)
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
