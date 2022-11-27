using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDevice.Models
{
    public class Cocktail
    {
        [JsonProperty("idDrink")]
        public int Id { get; set; }

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





        [JsonProperty("strMeasure1")]
        public string Measure1 { get; set; }


        [JsonProperty("strMeasure2")]
        public string Measure2 { get; set; }

        [JsonProperty("strMeasure3")]
        public string Measure3 { get; set; }

        [JsonProperty("strMeasure4")]
        public string Measure4 { get; set; }

        [JsonProperty("strMeasure5")]
        public string Measure5 { get; set; }


        [JsonProperty("strMeasure6")]
        public string Measure6 { get; set; }

        [JsonProperty("strMeasure7")]
        public string Measure7 { get; set; }

        [JsonProperty("strMeasure8")]
        public string Measure8 { get; set; }

        [JsonProperty("strMeasure9")]
        public string Measure9 { get; set; }

        [JsonProperty("strMeasure10")]
        public string Measure10 { get; set; }


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

        public string ingredient1Measure
        {
            get
            {
                return $"{Ingredient1} {Measure1}";
            }
        }

        public string ingredient2Measure
        {
            get
            {
                return $"{Ingredient2} {Measure2}";
            }
        }

        public string ingredient3Measure
        {
            get
            {
                return $"{Ingredient3} {Measure3}";
            }
        }

        public string ingredient4Measure
        {
            get
            {
                return $"{Ingredient4} {Measure4}";
            }
        }

        public string ingredient5Measure
        {
            get
            {
                return $"{Ingredient5} {Measure5}";
            }
        }

        public string ingredient6Measure
        {
            get
            {
                return $"{Ingredient6} {Measure6}";
            }
        }

        public string ingredient7Measure
        {
            get
            {
                return $"{Ingredient7} {Measure7}";
            }
        }

        public string ingredient8Measure
        {
            get
            {
                return $"{Ingredient8} {Measure8}";
            }
        }

        public string ingredient9Measure
        {
            get
            {
                return $"{Ingredient9} {Measure9}";
            }
        }

        public string ingredient10Measure
        {
            get
            {
                return $"{Ingredient10} {Measure10}";
            }
        }


    }
}
