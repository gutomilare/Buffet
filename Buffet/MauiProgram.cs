using Microsoft.Extensions.Logging;

namespace Buffet
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
                    fonts.AddFont("GreatVibes-Regular.ttf", "GreatVibes");
                    fonts.AddFont("PlayfairDisplay-Regular.ttf", "PlayfairDisplayRegular");
                    fonts.AddFont("PlayfairDisplay-Bold.ttf", "PlayfairDisplayBold");
                    fonts.AddFont("PlayfairDisplay-Italic.ttf", "PlayfairDisplayItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
