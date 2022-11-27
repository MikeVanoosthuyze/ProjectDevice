using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
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
            showNonAlcoholicCocktails();
        }

        private async Task showNonAlcoholicCocktails()
        {
            lvwNonAlcoholicCocktail.ItemsSource = await CocktailRepo.GetNonAlcoholicCocktails();
        }

        private void lvwNonAlcoholicCocktail_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // nagaan of er wel een object is
            if (lvwNonAlcoholicCocktail.SelectedItem != null)
            {
                // object opvragen
                Cocktail selected = (Cocktail)lvwNonAlcoholicCocktail.SelectedItem;
                // Naar detail pagina gaan.
                Navigation.PushAsync(new DetailPage(selected));
                // oneindige lussen voorkomen
                lvwNonAlcoholicCocktail.SelectedItem = selected;

            }
        }
    }
}