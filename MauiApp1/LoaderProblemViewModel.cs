using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class LoaderProblemViewModel : ObservableObject
    {
        [ObservableProperty] bool isBusy;
        [ObservableProperty] ObservableCollection<MyDto> _collection;

        public LoaderProblemViewModel() { 
        
            Collection =
            [
                new MyDto("aaaa", "aaaaa", "aaaaaaa", "aaaaaaaa"),
                new MyDto("aaaa", "aaaaa", "aaaaaaa", "aaaaaaaa"),
                new MyDto("aaaa", "aaaaa", "aaaaaaa", "aaaaaaaa"),
                new MyDto("aaaa", "aaaaa", "aaaaaaa", "aaaaaaaa"),
                new MyDto("aaaa", "aaaaa", "aaaaaaa", "aaaaaaaa"),
            ];

        }

        [RelayCommand]
        async Task ShowLoaderAsync()
        {

            try
            {
                // await SetBusyAsync();
                IsBusy = true;
                await Task.Delay(50);

                Task.Run(async () =>
                {

                    Console.WriteLine("Another thread...");
                    await Task.Delay(1000);
                    IsBusy = false;
                });

                await Shell.Current.DisplayAlert("Warning", "Time is passed!!", "Ok");
                await Shell.Current.GoToAsync("..", animate: true);

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
            }
            finally
            {
                // await SetNotBusyAsync();
                IsBusy = false;

                //await Shell.Current.GoToAsync("..", animate: true);
            }
        }


        partial void OnIsBusyChanged(bool value)
        {
            MainThread.InvokeOnMainThreadAsync(() =>
            {
                if (value)
                {
                    try
                    {
                        if (App.LoadingView == null)
                        {
                            App.LoadingView = new LoadingView();

                            Shell.Current.ShowPopup(App.LoadingView);
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        if (App.LoadingView != null)
                        {
                            App.LoadingView.Close();
                        }
                    }
                    catch
                    {
                    }
                    finally
                    {
                        App.LoadingView = null;
                    }
                }
            });
        }
    }

    public partial class MyDto : ObservableObject
    {


        [ObservableProperty] string _s1;
        [ObservableProperty] string _s2;
        [ObservableProperty] string _s3;
        [ObservableProperty] string _s4;

        public MyDto(string s1, string s2, string s3, string s4)
        {
            S1 = s1;
            S2 = s2;
            S3 = s3;
            S4 = s4;
        }
    }
}
