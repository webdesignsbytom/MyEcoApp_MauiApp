namespace MyEcoApp_MauiApp.View.Welcome;

public partial class WelcomeScreen : ContentPage
{
    public WelcomeScreen()
    {
        InitializeComponent();
        LoadMainPageAfterDelay();
    }

    private static async void LoadMainPageAfterDelay()
    {
        // Wait for 3 seconds (3000 milliseconds)
        await Task.Delay(3000);

        // Navigate to the MainPage
        await AppShell.Current.GoToAsync("///MainPage");
    }
}