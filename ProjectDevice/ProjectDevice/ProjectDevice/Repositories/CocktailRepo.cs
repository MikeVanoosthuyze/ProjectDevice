using Newtonsoft.Json;
using ProjectDevice.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDevice.Repositories
{
    public class CocktailRepo
    {

        public const string _BASEURL = "https://facocktails.azurewebsites.net/api/cocktails";

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<Cocktail>> GetCocktails()
        {
            string url = $"{_BASEURL}";

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

    }
}
