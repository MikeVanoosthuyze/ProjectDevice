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
    public partial class AddPage : ContentPage
    {

        public OwnCocktail cocktailContent { get; set; }

        public AddPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Add(object sender, EventArgs e)
        {
       
            string name = DrinkName.Text;
            string alcoholic = DrinkAlcoholic.Text;
            string instructions = DrinkInstructions.Text;
            string image = DrinkImage.Text;
            string in1 = DrinkIngredient1.Text;
            string in2 = DrinkIngredient2.Text;
            string in3 = DrinkIngredient3.Text;
            string in4 = DrinkIngredient4.Text;
            string in5 = DrinkIngredient5.Text;
            string in6 = DrinkIngredient6.Text;
            string in7 = DrinkIngredient7.Text;
            string in8 = DrinkIngredient8.Text;
            string in9 = DrinkIngredient9.Text;
            string in10 = DrinkIngredient10.Text;


            OwnCocktail newcocktail = new OwnCocktail();



            if (string.IsNullOrEmpty(DrinkName.Text))
            {
                await DisplayAlert("Error!", "Fill in the name of the drink", "OK");
                return;
            }
            if (string.IsNullOrEmpty(DrinkAlcoholic.Text))
            {
                await DisplayAlert("Error!", "Fill in if the drink is Alcoholic or Non Alcoholic!", "OK");
                return;
            }
            if (string.IsNullOrEmpty(DrinkInstructions.Text))
            {
                await DisplayAlert("Error!", "Fill in the instructions to make!", "OK");
                return;
            }
            if (string.IsNullOrEmpty(DrinkIngredient1.Text))
            {
                await DisplayAlert("Error!", "Enter at least 1 ingredient", "OK");
                return;
            }


            newcocktail.Name = name;
            newcocktail.Alcoholic = alcoholic;
            newcocktail.Instructions = instructions;
            newcocktail.Image = image;
            newcocktail.Ingredient1 = in1;
            newcocktail.Ingredient2 = in2;
            newcocktail.Ingredient3 = in3;
            newcocktail.Ingredient4 = in4;
            newcocktail.Ingredient5 = in5;
            newcocktail.Ingredient6 = in6;
            newcocktail.Ingredient7 = in7;
            newcocktail.Ingredient8 = in8;
            newcocktail.Ingredient9 = in9;
            newcocktail.Ingredient10 = in10;


            await CocktailRepo.AddCocktail(newcocktail);

            Navigation.PopAsync();

        }

        private async void back_btn_Clicked(object sender, EventArgs e)
        {
                Navigation.PopAsync();  
 
        }
    }
}