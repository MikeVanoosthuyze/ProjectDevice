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
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using static System.Net.Mime.MediaTypeNames;
using TabbedPage = Xamarin.Forms.TabbedPage;
using static Xamarin.Essentials.Permissions;

namespace ProjectDevice
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
