using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

namespace TestDependencyProperty.Views.CustomControls;

internal partial class TextBox2 : TextBox
{
	public TextBox2()
	{
		KeyDown += KeyDownEventHandler;
	}

	/// <summary>
	/// 依存関係プロパティーではない普通のプロパティー
	/// </summary>
	public String? NormalText
	{
		get => field;
		set
		{
			field = value;
			Text = "* " + value + " *";
		}
	}

	/// <summary>
	/// 依存関係プロパティーの登録
	/// </summary>
	public static readonly DependencyProperty KeyDownInfoProperty
		= DependencyProperty.Register(nameof(KeyDownInfo), typeof(String), typeof(TextBox2),
		new PropertyMetadata(null, new PropertyChangedCallback(OnKeyDownInfoChanged)));

	/// <summary>
	/// 依存関係プロパティーのラッパー
	/// </summary>
	public String? KeyDownInfo
	{
		get => (String?)GetValue(KeyDownInfoProperty);
		set => SetValue(KeyDownInfoProperty, value);
	}

	/// <summary>
	/// 依存関係プロパティー変更コールバック
	/// </summary>
	/// <param name="dependencyObject"></param>
	/// <param name="args"></param>
	private static void OnKeyDownInfoChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
	{
		if (dependencyObject is TextBox2 textBox2)
		{
			Debug.WriteLine($"KeyDownInfo changed: {textBox2}, {args.NewValue}");
		}
	}

	private void KeyDownEventHandler(Object sender, KeyRoutedEventArgs args)
	{
		// 依存関係プロパティーを変更
		KeyDownInfo = $"{args.Key} {Environment.TickCount}";
	}
}
