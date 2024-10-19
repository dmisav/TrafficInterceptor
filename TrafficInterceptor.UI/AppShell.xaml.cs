using TrafficInterceptor.UI.Views;

namespace TrafficInterceptor.UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(TrafficCollectionPage),typeof(TrafficCollectionPage));
	}
}
