using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;

namespace TestDependencyProperty.Views.CustomControls;

internal partial class StackPanel2 : StackPanel
{
	public StackPanel2()
	{
		_textBox.Width = 200;
		Children.Add(_textBox);
	}

	private readonly TextBox _textBox = new();

	/// <summary>
	/// 中継用の Binding
	/// </summary>
	public Binding? TextBinding
	{
		get;
		set
		{
			field = value;
			if (field != null)
			{
				// TextBox.Text にバインド
				// AOT の場合、[GeneratedBindableCustomProperty] を忘れていると例外が発生するので注意
				_textBox.SetBinding(TextBox.TextProperty, field);
			}
		}
	}
}
