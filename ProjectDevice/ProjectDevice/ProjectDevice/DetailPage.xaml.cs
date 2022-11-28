using ProjectDevice.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDevice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DetailPage : ContentPage
    {
        public OwnCocktail CocktailContent { get; set; }


        public DetailPage(OwnCocktail cocktail)
        {
            InitializeComponent();
            CocktailContent = cocktail;
            showCocktailContent();
        }

        private void showCocktailContent()
        {


            lblTitle.Text = this.CocktailContent.Name;
            lblInstructions.Text = this.CocktailContent.Instructions;
            imgType.Source = this.CocktailContent.Image;
            lblin1.Text = this.CocktailContent.Ingredient1;
            lblin2.Text = this.CocktailContent.Ingredient2;
            lblin3.Text = this.CocktailContent.Ingredient3;
            lblin4.Text = this.CocktailContent.Ingredient4;
            lblin5.Text = this.CocktailContent.Ingredient5;
            lblin6.Text = this.CocktailContent.Ingredient6;
            lblin7.Text = this.CocktailContent.Ingredient7;
            lblin8.Text = this.CocktailContent.Ingredient8;
            lblin9.Text = this.CocktailContent.Ingredient9;
            lblin10.Text = this.CocktailContent.Ingredient10;

        }
    }

}