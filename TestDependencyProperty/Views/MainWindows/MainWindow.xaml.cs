using Microsoft.UI.Xaml;

using TestDependencyProperty.ViewModels.MainWindows;

namespace TestDependencyProperty.Views.MainWindows;

internal sealed partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
		Content = new MainPage();
	}

	public MainPageViewModel ViewModel => ((MainPage)Content).ViewModel;
}
