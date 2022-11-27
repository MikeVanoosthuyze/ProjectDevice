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
        public Cocktail CocktailContent { get; set; }


        public DetailPage(Cocktail cocktail)
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
            lblin1.Text = this.CocktailContent.ingredient1Measure;
            lblin2.Text = this.CocktailContent.ingredient2Measure;
            lblin3.Text = this.CocktailContent.ingredient3Measure;
            lblin4.Text = this.CocktailContent.ingredient4Measure;
            lblin5.Text = this.CocktailContent.ingredient5Measure;
            lblin6.Text = this.CocktailContent.ingredient6Measure;
            lblin7.Text = this.CocktailContent.ingredient7Measure;
            lblin8.Text = this.CocktailContent.ingredient8Measure;
            lblin9.Text = this.CocktailContent.ingredient9Measure;
            lblin10.Text = this.CocktailContent.ingredient10Measure;

        }
    }

}