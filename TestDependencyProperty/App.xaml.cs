using Microsoft.UI.Xaml;

namespace TestDependencyProperty;

public partial class App : Application
{
	public static WindowEx MainWindow { get; } = new MainWindow();

	public App()
	{
		InitializeComponent();
		UnhandledException += App_UnhandledException;
	}

	private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
	{
	}

	protected async override void OnLaunched(LaunchActivatedEventArgs args)
	{
		base.OnLaunched(args);
		MainWindow.Activate();
	}
}
