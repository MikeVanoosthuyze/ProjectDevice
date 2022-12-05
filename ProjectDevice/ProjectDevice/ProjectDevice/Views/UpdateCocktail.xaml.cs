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

namespace ProjectDevice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateCocktail : ContentPage
    {
        public OwnCocktail CocktailContent { get; set; }
        public UpdateCocktail(OwnCocktail content)
        {
            InitializeComponent();
            CocktailContent = content;
            Debug.WriteLine(CocktailContent);
            Showdata();
        }

        private void Showdata()
        {

            
            DrinkName.Text = this.CocktailContent.Name;
            DrinkAlcoholic.Text = this.CocktailContent.Alcoholic;
            DrinkInstructions.Text = this.CocktailContent.Instructions;
            DrinkImage.Text = this.CocktailContent.Image;
            DrinkIngredient1.Text = this.CocktailContent.Ingredient1;
            DrinkIngredient2.Text = this.CocktailContent.Ingredient2;
            DrinkIngredient3.Text = this.CocktailContent.Ingredient3;
            DrinkIngredient4.Text = this.CocktailContent.Ingredient4;
            DrinkIngredient5.Text = this.CocktailContent.Ingredient5;
            DrinkIngredient6.Text = this.CocktailContent.Ingredient6;
            DrinkIngredient7.Text = this.CocktailContent.Ingredient7;
            DrinkIngredient8.Text = this.CocktailContent.Ingredient8;
            DrinkIngredient9.Text = this.CocktailContent.Ingredient9;
            DrinkIngredient10.Text = this.CocktailContent.Ingredient10;

        }

        private void back_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Update_btn_Clicked(object sender, EventArgs e)
        {

            string id = CocktailContent.Id;
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


            OwnCocktail Updatecocktail = new OwnCocktail();


            Updatecocktail.Id = id;
            Updatecocktail.Name = name;
            Updatecocktail.Alcoholic = alcoholic;
            Updatecocktail.Instructions = instructions;
            Updatecocktail.Image = image;
            Updatecocktail.Ingredient1 = in1;
            Updatecocktail.Ingredient2 = in2;
            Updatecocktail.Ingredient3 = in3;
            Updatecocktail.Ingredient4 = in4;
            Updatecocktail.Ingredient5 = in5;
            Updatecocktail.Ingredient6 = in6;
            Updatecocktail.Ingredient7 = in7;
            Updatecocktail.Ingredient8 = in8;
            Updatecocktail.Ingredient9 = in9;
            Updatecocktail.Ingredient10 = in10;


            await CocktailRepo.UpdateCocktail(Updatecocktail);

            Navigation.PopAsync();

        }
    }
}