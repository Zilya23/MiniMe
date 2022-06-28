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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            lv_task.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void lv_task_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            TaskForMiniMe selectedTask = (TaskForMiniMe)e.SelectedItem;
            TaskPage contentPage = new TaskPage();
            contentPage.BindingContext = selectedTask;
            await Navigation.PushAsync(contentPage);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            TaskForMiniMe selectedTask = new TaskForMiniMe();
            TaskPage contentPage = new TaskPage();
            contentPage.BindingContext = selectedTask;
            await Navigation.PushAsync(contentPage);
        }
    }
}