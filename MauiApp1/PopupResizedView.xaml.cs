using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class PopupResizedView : Popup
{
	public PopupResizedView()
	{
		InitializeComponent();

        border.IsVisible = false;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        border.IsVisible = true;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Message", "Button clicked", "Ok");
    }
}