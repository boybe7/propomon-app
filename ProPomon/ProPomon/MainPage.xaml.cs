using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProPomon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MonsterInfo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonsterInfo());
        }
    }
}
