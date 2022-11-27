﻿using ProjectDevice.Models;
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
    public partial class Alcoholic : ContentPage
    {
        public Alcoholic()
        {
            InitializeComponent();

            showAlcoholicCocktails();
            testRepo();
        }

        private async Task showAlcoholicCocktails()
        {

            lvwAlcoholicCocktail.ItemsSource = await CocktailRepo.GetCocktails();
        }

        private void lvwAlcoholicCocktail_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            // nagaan of er wel een object is
            if (lvwAlcoholicCocktail.SelectedItem != null)
            {
                // object opvragen
                OwnCocktail selected = (OwnCocktail)lvwAlcoholicCocktail.SelectedItem;
                // Naar detail pagina gaan.
                Navigation.PushAsync(new DetailPage(selected));
                // oneindige lussen voorkomen
                lvwAlcoholicCocktail.SelectedItem = selected;

            }
        }

        private async Task testRepo()
            {
                 List<Cocktail> cocktails = await CocktailRepo.GetAlcoholicCocktails();
            foreach (var cocktail in cocktails)
            {
                Debug.WriteLine($"{cocktail.Name} -- {cocktail.Alcoholic} ");
                 }



                 //*Test AddCocktail *//

            /*     Cocktail item = new Cocktail
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
                 };*/

                 /*await CocktailRepo.AddCocktail(item);*/



            }
    }
}