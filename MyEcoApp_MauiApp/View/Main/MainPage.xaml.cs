namespace MyEcoApp_MauiApp.View.Main
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///RegisterPage");
        }
    }
}