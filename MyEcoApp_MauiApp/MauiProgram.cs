using Microsoft.Extensions.Logging;
using MyEcoApp_MauiApp.Model.User;
using MyEcoApp_MauiApp.Services.Users;
using MyEcoApp_MauiApp.View.Login;
using MyEcoApp_MauiApp.View.Register;
using MyEcoApp_MauiApp.ViewModel.Login;
using MyEcoApp_MauiApp.ViewModel.Register;

namespace MyEcoApp_MauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<RegisterService>();
            builder.Services.AddSingleton<RegisterPage>();
            builder.Services.AddSingleton<RegisterPageViewModel>();
            builder.Services.AddSingleton<LoginService>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<User>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}