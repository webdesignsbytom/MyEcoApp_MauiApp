using MyEcoApp_MauiApp.ViewModel.Login;

namespace MyEcoApp_MauiApp.View.Login;

public partial class LoginPage : ContentPage
{
	public LoginPageViewModel LoginViewModel { get; set; }
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		BindingContext = LoginViewModel = loginPageViewModel;
	}
}