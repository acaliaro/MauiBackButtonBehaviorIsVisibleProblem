namespace MauiApp1;

public partial class LoaderProblemPage : ContentPage
{
	public LoaderProblemPage(LoaderProblemViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}