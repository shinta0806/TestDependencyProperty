using Microsoft.UI.Xaml.Controls;

using TestDependencyProperty.ViewModels.MainWindows;

namespace TestDependencyProperty.Views.MainWindows;

internal sealed partial class MainPage : Page
{
	public MainPage()
	{
		ViewModel = new();
		InitializeComponent();

		// 中継用の Binding 用
		DataContext = ViewModel;
	}

	public MainPageViewModel ViewModel
	{
		get;
	}
}
