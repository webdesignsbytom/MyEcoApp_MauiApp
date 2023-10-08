using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyEcoApp_MauiApp.Services.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoApp_MauiApp.ViewModel.Login
{
    public partial class LoginPageViewModel : ObservableObject
    {
        public LoginService LoginService { get; set; }

        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string submitBtn = "Login";

        public LoginPageViewModel() { }
        public LoginPageViewModel(LoginService loginService)
        {
            LoginService = loginService;
        }

        [RelayCommand]
        async Task PostLogin()
        {
            Debug.WriteLine("AAAAAAAAAAAAAAAAAAAA");
            await LoginService.LoginUser(Username, Password);
            SubmitBtn = "Login Successful!";
        }

        [RelayCommand]
        public static void CloseKeyboard()
        {
            App.Current.MainPage.Focus();
        }
    }
}