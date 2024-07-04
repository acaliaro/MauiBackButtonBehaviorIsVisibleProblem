
namespace MauiApp1
{
    public partial class App : Application
    {
        public static LoadingView LoadingView;

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
