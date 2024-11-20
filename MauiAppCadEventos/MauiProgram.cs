using Microsoft.Extensions.Logging;

namespace MauiAppCadEventos
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
                    fonts.AddFont("CreatoDisplay-Black.ttf", "CreatoDisplay");

                    fonts.AddFont("Neometra-Caps-FFP.ttf", "Neometra");



                    fonts.AddFont("Timess.ttf", "Timess");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
