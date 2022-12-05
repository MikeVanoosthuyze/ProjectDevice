using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDevice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonAlcoholic : ContentPage
    {
        public NonAlcoholic()
        {
            InitializeComponent();
            /*testRepo();*/

            /* Gesture Toevoegen aan label */
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;
            lblAddDrink.GestureRecognizers.Add(tapGesture);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showNonAlcoholicCocktails();
        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }

        private async Task showNonAlcoholicCocktails()
        {

            List<Drink> results = new List<Drink>();
            List<Cocktail> list1 = await CocktailRepo.GetNonAlcoholicCocktails();
            List<OwnCocktail> list2 = await CocktailRepo.GetOwnNonAlcholicCocktails();
            results.AddRange(list1);
            results.AddRange(list2);

            lvwNonAlcoholicCocktail.ItemsSource = results;
        }

        private void lvwNonAlcoholicCocktail_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // nagaan of er wel een object is
            if (lvwNonAlcoholicCocktail.SelectedItem != null)
            {
                // object opvragen
                Drink selected = (Drink)lvwNonAlcoholicCocktail.SelectedItem;
                // Naar detail pagina gaan.
                Navigation.PushAsync(new DetailPage(selected));
                // oneindige lussen voorkomen
                lvwNonAlcoholicCocktail.SelectedItem = selected;

            }
        }


        /*        private async void testRepo()
        {
            List<Cocktail> cocktails = await CocktailRepo.GetNonAlcoholicCocktails();
            foreach (var cocktail in cocktails)
            {
                Debug.WriteLine($"{cocktail.Name} -- {cocktail.Alcoholic} ");
            }
        }*/

    }
}