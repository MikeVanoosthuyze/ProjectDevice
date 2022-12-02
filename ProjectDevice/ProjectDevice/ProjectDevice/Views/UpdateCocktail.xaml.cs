using ProjectDevice.Models;
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
        public Drink CocktailContent { get; set; }
        public UpdateCocktail(Drink
            cocktail)
        {
            InitializeComponent();

            cocktail = CocktailContent;

            updateTest();

        }

        private void updateTest()
        {
            Debug.WriteLine(CocktailContent.Name);
        }
    }
}