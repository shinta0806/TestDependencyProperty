using Microsoft.UI.Xaml.Controls;

using TestDependencyProperty.ViewModels.MainWindows;

namespace TestDependencyProperty.Views.MainWindows;

internal sealed partial class MainPage : Page
{
	public MainPage()
	{
		ViewModel = new();
		InitializeComponent();
	}

	public MainPageViewModel ViewModel
	{
		get;
	}
}
