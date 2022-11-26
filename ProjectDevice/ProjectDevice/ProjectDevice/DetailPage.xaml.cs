using ProjectDevice.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        }
    }

}