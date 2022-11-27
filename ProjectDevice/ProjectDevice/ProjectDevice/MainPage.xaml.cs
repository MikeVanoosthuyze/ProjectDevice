using ProjectDevice.Models;
using ProjectDevice.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using static System.Net.Mime.MediaTypeNames;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace ProjectDevice
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
/*        public async Task showCocktails()
        {
            
            
        }*/

        /*        public static List<BaseClass> GetAllCocktails()
                {

                    List<BaseClass> results = new List<BaseClass>();

                    results.AddRange(GetOwnCocktails());
                    results.AddRange(GetCocktails());

                    return results;

                }*/
    }
}
