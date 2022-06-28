using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LvlPage : ContentPage
    {
        public LvlPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MyLvl myLvl = App.myLvl.GetLvl(1);
            lvl lvls = TaskDone.GetLvl(myLvl.XPcount);
            base.OnAppearing();
        }
    }
}