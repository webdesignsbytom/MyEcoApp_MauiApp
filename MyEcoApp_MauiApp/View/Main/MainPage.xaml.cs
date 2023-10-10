namespace MyEcoApp_MauiApp.View.Main
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void UserLogRegBtn_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///ProjectsMainPage");
        }

        private async void GamesPageBtn_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///GamesPage");

        }
        private async void AboutPageBtn_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///ProjectsMainPage");

        }
        private async void ProjectsPageBtn_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///ProjectsMainPage");

        }


    }
}