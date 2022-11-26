using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectDevice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /*testRepo();*/
            showCocktails();
            /*showCocktails();*/
        }
        public async Task showCocktails()
        {
            lvwCocktail.ItemsSource = await CocktailRepo.GetOwnCocktails();
            lvwCocktail.ItemsSource = await CocktailRepo.GetCocktails();
        }

        public static List<BaseClass> GetAllCocktails()
        {

            List<BaseClass> results = new List<BaseClass>();

            results.AddRange(GetOwnCocktails());
            results.AddRange(GetCocktails());

            return results;

        }


        /*        public async Task showCocktails()
                {

                }*/

        /* private async Task testRepo()
         {
             List<Cocktail> cocktails = await CocktailRepo.GetCocktails();
             foreach(var cocktail in cocktails)
             {
                 Debug.WriteLine(cocktail.Name);
             }



             *//*Test AddCocktail *//*

             Cocktail item = new Cocktail
             {
                 Name = "PINA COLADA",
                 Alcoholic = true,
                 Instructions = "Doe de witte rum, de kokosmelk en het ananassap in de blender en voeg 2-3 eetlepels gemalen ijs toe. Meng alles glad. Schenk in een cocktailglas en serveer met een rietje. Versier de rand met een partje ananas.",
                 Image = "https://bettyskitchen.nl/wp-content/uploads/2016/05/klassieke_cocktails_pina_colada_shutterstock_420735802.jpg",
                 Ingredient1 = "25 ml white rum",
                 Ingredient2 = "50 ml thick coconut milk",
                 Ingredient3 = "1 dl pineapple juice",
                 Ingredient4 = "crushed ice",
                 Ingredient5 = "",
                 Ingredient6 = "",
                 Ingredient7 = "",
                 Ingredient8 = "",
                 Ingredient9 = "",
                 Ingredient10 = "",
             };

             await CocktailRepo.AddCocktail(item);



         }*/
    }
}
