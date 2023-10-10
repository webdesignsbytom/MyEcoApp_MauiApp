namespace MyEcoApp_MauiApp.View.Games;

public partial class GamesPage : ContentPage
{
	public GamesPage()
	{
		InitializeComponent();
	}

    private async void GamesListBtn_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///ProjectsMainPage   ");
    }
}