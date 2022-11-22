﻿using Newtonsoft.Json;
using ProjectDevice.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDevice.Repositories
{
    public class CocktailRepo
    {

        public const string _BASEURL = "https://facocktails.azurewebsites.net/api/";

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        /*Cocktails opvragen*/
        public static async Task<List<Cocktail>> GetCocktails()
        {
            string url = $"{_BASEURL}/cocktails";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    /*Opvragen van Api*/
                    string json = await client.GetStringAsync(url);
                    /* Hier doet newtonsoft zn werk */
                    List<Cocktail> cocktail = JsonConvert.DeserializeObject<List<Cocktail>>(json);
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
        public static async Task AddCocktail(Cocktail item)
        {
            string url = $"{_BASEURL}add/cocktail";
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


        public static async Task UpdateCocktail(Cocktail item)
        {
            string url = $"{_BASEURL}update/cocktail";
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
