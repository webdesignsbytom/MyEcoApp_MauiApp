using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyEcoApp_MauiApp.Services.Users;
using System.Diagnostics;

namespace MyEcoApp_MauiApp.ViewModel.Register
{
    public partial class RegisterPageViewModel : ObservableObject
    {
        public RegisterService RegisterService { get; set; }

        [ObservableProperty]
        public string email;

        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string confirmPassword;

        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string submitBtn = "Submit";

        public RegisterPageViewModel() { }
        public RegisterPageViewModel(RegisterService registerService)
        {
            RegisterService = registerService;
        }


        [RelayCommand]
        async Task PostRegister()
        {
            Debug.WriteLine("AAAAAAAAAAAAAAAAAAAA");

            if (Password != ConfirmPassword)
            {
                return;
            }
            else
            {
                await RegisterService.RegisterNewMember(Username, Email, FirstName, LastName, Password);
                // Reset fields 
                Email = "";
                Username = "";
                FirstName = "";
                LastName = "";
                Password = "";

                SubmitBtn = "Registration Successful!";
            }
        }

        [RelayCommand]
        public void CloseKeyboard()
        {
            App.Current.MainPage.Focus();
        }
    }
}
