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

    }
}
