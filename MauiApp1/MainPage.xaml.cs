using CommunityToolkit.Maui.Views;
using daze.dazeapp.tests.Dequeuer;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoaderProblemPage), true);

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var popup = new PopupResizedView();

            Shell.Current.ShowPopup(popup);
        }
    }

}
