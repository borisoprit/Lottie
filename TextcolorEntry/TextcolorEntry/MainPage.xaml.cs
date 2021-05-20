using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextcolorEntry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void HandlePlay_Clicked(object sender, EventArgs e)
        {
            SwipeAnimation.PlayAnimation();
        }

        void HandlePause_Clicked(object sender, EventArgs e)
        {
            SwipeAnimation.PlayAnimation();
        }
    }
}
