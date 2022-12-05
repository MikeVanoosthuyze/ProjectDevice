using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDevice.Models
{
    public class OwnCocktail : Drink
    {

        [JsonProperty("id")]
        public string Id { get; set; }

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
