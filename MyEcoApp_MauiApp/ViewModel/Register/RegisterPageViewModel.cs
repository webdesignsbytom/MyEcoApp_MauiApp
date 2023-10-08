using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyEcoApp_MauiApp.ViewModel.Register
{
    public partial class RegisterPageViewModel : ObservableObject
    {            
        [ObservableProperty]
        public string email;

        [ObservableProperty]
        public string password;
        
        [ObservableProperty]
        public string firstName;
        
        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string submitBtn = "Submit";

        public RegisterPageViewModel() { }


        [RelayCommand]
        async Task PostRegister()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAA");
            /*await Database.PostNewHighScore(Username, State.FinishingScore);
            SubmitBtn = "Score Posted!";
            Username = "";*/
        }

        [RelayCommand]
        public void CloseKeyboard()
        {
            App.Current.MainPage.Focus();
        }
    }
}
