using MyEcoApp_MauiApp.ViewModel.Register;

namespace MyEcoApp_MauiApp.View.Register;

public partial class RegisterPage : ContentPage
{
	public RegisterPageViewModel Rpvm { get; set; }
	public RegisterPage(RegisterPageViewModel rpvm)
	{
		InitializeComponent();
        BindingContext = Rpvm = rpvm;
    }
}