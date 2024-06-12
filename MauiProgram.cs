using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MauiAppBasic.Services;

namespace MauiAppBasic
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
            // Common services registration
            builder.Services.AddSingleton<IChatbotService>();
            builder.Services.AddSingleton<ISpeechRecognitionService>();
            builder.Services.AddSingleton<ITelephonyService>();
            builder.Services.AddSingleton<ITextToSpeechService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
