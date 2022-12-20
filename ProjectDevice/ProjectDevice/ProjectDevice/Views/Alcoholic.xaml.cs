using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace ProjectDevice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alcoholic : ContentPage
    {
        public Alcoholic()
        {
            InitializeComponent();

            testRepo();
            /* Gesture Toevoegen aan label */
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;
            lblAddDrink.GestureRecognizers.Add(tapGesture);

        }

        // Wordt telkens uitgevoerd wanneer pagina terug te voorschijn komt.
        // Zorgt dat nieuwe kaartjes meteen in het overzicht verschijnene.
        protected override void OnAppearing()
        {
            base.OnAppearing();
            showAlcoholicCocktails();
        }


        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }

        private async void showAlcoholicCocktails()
        {

            /* Niewe list aanmaken om eigen api samen te voegen met api gevonden op internet
                List aanmaken waar we de gefilterde items insteken. */
            List<Drink> mixedList = new List<Drink>();
            List<Drink> filteredList = new List<Drink>();

            /* owncocktails en cocktails van online gevonden API ophalen */
            List<OwnCocktail> list1 = await CocktailRepo.GetOwnCocktails();
            List<Cocktail> list2 = await CocktailRepo.GetCocktails();
            /* 2 lists in 1 list steken */
            mixedList.AddRange(list2);
            mixedList.AddRange(list1);

            foreach (Drink item in mixedList)
            {
                if (item.Alcoholic.ToLower() == "alcoholic")
                {
                    /*Debug.WriteLine($"{item.Name} -- {item.Alcoholic}");*/
                    filteredList.Add(item);
                }
            }

            lvwAlcoholicCocktail.ItemsSource = filteredList;
        }

        private void lvwAlcoholicCocktail_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            // nagaan of er wel een object is
            if (lvwAlcoholicCocktail.SelectedItem != null)
            {
                // object opvragen
                Drink selected = (Drink)lvwAlcoholicCocktail.SelectedItem;
                // Naar detail pagina gaan.
                Navigation.PushAsync(new DetailPage(selected));
                // oneindige lussen voorkome
                lvwAlcoholicCocktail.SelectedItem = selected;
            }
        }

        private async void testRepo()
        {

/*            List<Cocktail> random = await CocktailRepo.GetRandomCocktails();
            foreach(Drink item in random)
            {
                Debug.WriteLine(item.Name);
            }*/
            


/*            List<OwnCocktail> cocktails = await CocktailRepo.GetOwnCocktails();
            foreach (var cocktail in cocktails)
            {
                Debug.WriteLine(cocktail);
            }*/


/*            OwnCocktail item = new OwnCocktail
            {
                Name = "Blabla blabla blabla",
                Alcoholic = "Non Alcoholic",
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

            await CocktailRepo.AddCocktail(item);*/

        }

    }
}