using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectDevice.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ProjectDevice.Repositories
{
    public class CocktailRepo
    {

        public const string _OWNBASEURL = "https://facocktails.azurewebsites.net/api/";

        public const string _BASEURL = "https://www.thecocktaildb.com/api/json/v1/1/";
        

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }


        /*Alcoholic cocktail opvragen*/
        public static async Task<List<Cocktail>> GetAlcoholicCocktails()
        {
            string url = $"{_BASEURL}search.php?f=a";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);

                    //deserialize object to JObject (< newtonsoft)
                    JObject fullObject = JsonConvert.DeserializeObject<JObject>(json);

                    //path to child token
                    JToken data = fullObject.SelectToken("drinks");

                    /* Hier doet newtonsoft zn werk */
                    List<Cocktail> cocktails = data.ToObject<List<Cocktail>>();

                    /* Nieuwe lijst aanmaken */
                    List<Cocktail> AlcoholicDrinks = new List<Cocktail>();

                    foreach (Cocktail cocktail in cocktails)
                    {
                        if (cocktail.Alcoholic == "Alcoholic")
                        {
                            AlcoholicDrinks.Add(cocktail);
                        }
                    }

                    return cocktails;
                }
                catch (Exception ex)
                {
                    // ALWAYS add a breakpoint here
                    throw ex;
                }
            }

        }

        /*Non Alcoholic cocktail opvragen*/
        public static async Task<List<Cocktail>> GetNonAlcoholicCocktails()
        {
            string url = $"{_BASEURL}search.php?f=a";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);

                    //deserialize object to JObject (< newtonsoft)
                    JObject fullObject = JsonConvert.DeserializeObject<JObject>(json);

                    //path to child token
                    JToken data = fullObject.SelectToken("drinks");

                    /* Hier doet newtonsoft zn werk */
                    List<Cocktail> cocktails = data.ToObject<List<Cocktail>>();

                    /* Nieuwe lijst aanmaken */
                    List<Cocktail> AlcoholicDrinks = new List<Cocktail>();

                    foreach (Cocktail cocktail in cocktails)
                    {
                        if (cocktail.Alcoholic == "Alcoholic")
                        {
                            AlcoholicDrinks.Add(cocktail);
                        }
                    }

                    return AlcoholicDrinks;
                }
                catch (Exception ex)
                {
                    // ALWAYS add a breakpoint here
                    throw ex;
                }
            }

        }

        /*Alcoholic OwnCocktails opvragen*/
        public static async Task<List<OwnCocktail>> GetOwnAlcoholicCocktails()
        {
            string url = $"{_OWNBASEURL}/cocktails";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);
                    /* Hier doet newtonsoft zn werk */
                    List<OwnCocktail> cocktails = JsonConvert.DeserializeObject<List<OwnCocktail>>(json);


                    /*Nieuwe lijst aanmaken*/
                    List<OwnCocktail> AlcoholicDrinks = new List<OwnCocktail>();

                    foreach (OwnCocktail cocktail in cocktails)
                    {
                        if (cocktail.Alcoholic == "Alcoholic")
                        {
                            AlcoholicDrinks.Add(cocktail);
                        }
                    }

                    return AlcoholicDrinks;



                }
                catch (Exception ex)
                {
                    // ALWAYS add a breakpoint here
                    throw ex;
                }
            }

        }


        /*Alcoholic OwnCocktails opvragen*/
        public static async Task<List<OwnCocktail>> GetOwnNonAlcholicCocktails()
        {
            string url = $"{_OWNBASEURL}/cocktails";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);
                    /* Hier doet newtonsoft zn werk */
                    List<OwnCocktail> cocktails = JsonConvert.DeserializeObject<List<OwnCocktail>>(json);


                    /* Nieuwe lijst aanmaken */
                    List<OwnCocktail> NonAlcoholicDrinks = new List<OwnCocktail>();

                    foreach (OwnCocktail cocktail in cocktails)
                    {
                        
                        if (cocktail.Alcoholic != "Alcoholic")
                        {
                            NonAlcoholicDrinks.Add(cocktail);
                        }
                    }
                    return NonAlcoholicDrinks;



                }
                catch (Exception ex)
                {
                    // ALWAYS add a breakpoint here
                    throw ex;
                }
            }

        }

        /*Cocktails toevoegen*/
        public static async Task AddCocktail(OwnCocktail item)
        {
            string url = $"{_OWNBASEURL}add/cocktail";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(item);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errmsg = $"Unsuccesfull POST to url: {url} and object json: {json}";
                        throw new Exception(errmsg);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /*Updaten van Cocktails*/
        public static async Task UpdateCocktail(OwnCocktail item)
        {
            string url = $"{_OWNBASEURL}update/cocktail";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(item);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync(url, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errmsg = $"Unsuccesfull PUT to url: {url} and object json: {json}";
                        throw new Exception(errmsg);
                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



    }
}
