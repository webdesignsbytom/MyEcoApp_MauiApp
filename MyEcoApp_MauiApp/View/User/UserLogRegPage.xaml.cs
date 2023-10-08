namespace MyEcoApp_MauiApp.View.User;

public partial class UserLogRegPage : ContentPage
{
	public UserLogRegPage()
	{
		InitializeComponent();
	}

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///RegisterPage");
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///LoginPage");
    }
}