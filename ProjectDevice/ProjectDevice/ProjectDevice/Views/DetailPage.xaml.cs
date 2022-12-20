using ProjectDevice.Models;
using ProjectDevice.Repositories;
using ProjectDevice.Views;
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
        public Drink Content { get; set; }

        public DetailPage(Drink cocktail)
        {
            InitializeComponent();
            Content = cocktail;
            
            if ((Content as OwnCocktail) != null)
            {
                OwnCocktail item = (OwnCocktail)Content;
                showOwnCocktailContent(item);
            }
            if ((Content as Cocktail) != null)
            {
                Cocktail item = (Cocktail)Content;
                showCocktailContent(item);
            }


        }

        private void showCocktailContent(Cocktail item)
        {


            /*Objecten van Cocktail*/
            lblTitle.Text = item.Name;
            lblInstructions.Text = item.Instructions;
            imgType.Source = item.Image;
            lblin1.Text = item.Ingredient1Measure;
            lblin2.Text = item.Ingredient2Measure;
            lblin3.Text = item.Ingredient3Measure;
            lblin4.Text = item.Ingredient4Measure;
            lblin5.Text = item.Ingredient5Measure;
            lblin6.Text = item.Ingredient6Measure;
            lblin7.Text = item.Ingredient7Measure;
            lblin8.Text = item.Ingredient8Measure;
            lblin9.Text = item.Ingredient9Measure;
            lblin10.Text = item.Ingredient10Measure;

            btn_edit.IsEnabled = false;
            btn_edit.BackgroundColor = Color.LightGray;
            btn_edit.TextColor = Color.Gray;
        }

        private void showOwnCocktailContent(OwnCocktail item)
        {

            /*CocktailDetail CocktailContent = CocktailRepo.GetAlcoholicDetail(selected.Id);*/

                /* Objecten van OwnCocktail */
                lblTitle.Text = item.Name;
                lblInstructions.Text = item.Instructions;
                imgType.Source = item.Image;
                lblin1.Text = item.Ingredient1;
                lblin2.Text = item.Ingredient2;
                lblin3.Text = item.Ingredient3;
                lblin4.Text = item.Ingredient5;
                lblin6.Text = item.Ingredient6;
                lblin7.Text = item.Ingredient7;
                lblin8.Text = item.Ingredient8;
                lblin9.Text = item.Ingredient9;
                lblin10.Text = item.Ingredient10;
        }

        private void btn_back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btn_edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateCocktail((OwnCocktail)Content));
        }

    }

}