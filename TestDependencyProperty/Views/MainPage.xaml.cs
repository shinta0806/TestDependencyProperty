using Microsoft.UI.Xaml.Controls;

using TestDependencyProperty.ViewModels;

namespace TestDependencyProperty.Views;

public sealed partial class MainPage : Page
{
	public MainViewModel ViewModel
	{
		get;
	}

	public MainPage()
	{
		ViewModel = new();
		InitializeComponent();
	}
}
