using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppInventario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnprod_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Produccion());
        }
        private void btnpick_Clicked(object sender, EventArgs e)
        {

        }
    }
}
