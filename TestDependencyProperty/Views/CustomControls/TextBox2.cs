using Microsoft.UI.Xaml.Controls;

namespace TestDependencyProperty.Views.CustomControls;

internal partial class TextBox2 : TextBox
{
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
}
