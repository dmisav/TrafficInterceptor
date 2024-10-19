using Microsoft.Extensions.Logging;
using TrafficInterceptor.Domain;
using TrafficInterceptor.UI.Views;

namespace TrafficInterceptor.UI;

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
		builder.Services.AddSingleton<IProtocolProvider,ProtocolProvider>();
		builder.Services.AddTransient<TrafficCollectionPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
