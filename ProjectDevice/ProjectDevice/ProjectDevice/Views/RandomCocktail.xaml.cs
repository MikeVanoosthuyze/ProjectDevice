using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDevice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomCocktail : ContentPage
    {

        /* Property aanmaken die de random cocktail bijhoudt */
        public List<Drink> Content { get; set; }

        public RandomCocktail()
        {
            InitializeComponent();       
        }

        private async void btn_random_Clicked(object sender, EventArgs e)
        {

            /* Random cocktail ophalen */
            List<Cocktail> random = await CocktailRepo.GetRandomCocktails();

            /* Variabele maken van het type Drink zodat ik dit gelijk kan stellen aan de globale property Content */
            List<Drink> ranCocktail = new List<Drink>();

            /* RandCocktail is Content */
            Content = ranCocktail;

            foreach (Cocktail item in random)
            {
                imgType.Source = item.Image;
                lblTitle.Text = item.Name; 
                /* Voeg de cocktail toe aan ranCocktail */
                ranCocktail.Add(item);
            }
        }

        private void btn_detail_Clicked(object sender, EventArgs e)
        {
            foreach(Drink item in Content) {
                Navigation.PushAsync(new DetailPage(item));
            }

        }
    }
}