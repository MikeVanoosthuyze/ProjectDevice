﻿using Newtonsoft.Json;
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

namespace ProjectDevice.Repositories
{
    public class CocktailRepo
    {

        public const string _OWNBASEURL = "https://facocktails.azurewebsites.net/api/";

        public const string _BASEURL = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s";

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }


        /*Cocktails opvragen*/
        public static async Task<List<Cocktail>> GetCocktails()
        {
            string url = $"{_BASEURL}";

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

                    return cocktails;
                }
                catch (Exception ex)
                {
                    // ALWAYS add a breakpoint here
                    throw ex;
                }
            }

        }

        /*Cocktails opvragen*/
        public static async Task<List<OwnCocktail>> GetOwnCocktails()
        {
            string url = $"{_OWNBASEURL}/cocktails";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);
                    /* Hier doet newtonsoft zn werk */
                    List<OwnCocktail> cocktail = JsonConvert.DeserializeObject<List<OwnCocktail>>(json);
                    return cocktail;
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

        /**/
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
