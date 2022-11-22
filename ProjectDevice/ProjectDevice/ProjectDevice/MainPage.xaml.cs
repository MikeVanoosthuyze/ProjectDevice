using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ProjectDevice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            testRepo();
            showCocktails();
        }

        private async Task showCocktails()
        {
            lvwCocktail.ItemsSource = await CocktailRepo.GetCocktails();
        }

        private async Task testRepo()
        {
            List<Cocktail> cocktails = await CocktailRepo.GetCocktails();
            foreach(var cocktail in cocktails)
            {
                Debug.WriteLine(cocktail);
            }
        }
    }
}
