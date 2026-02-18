// ============================================================================
// 
// メインページの ViewModel
// 
// ============================================================================

// ----------------------------------------------------------------------------
// 
// ----------------------------------------------------------------------------

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestDependencyProperty.ViewModels.MainWindows;

internal partial class MainPageViewModel : ObservableRecipient
{
	// ====================================================================
	// コンストラクター
	// ====================================================================

	/// <summary>
	/// メインコンストラクター
	/// </summary>
	public MainPageViewModel()
	{
	}

	// ====================================================================
	// public プロパティー
	// ====================================================================

	// --------------------------------------------------------------------
	// View 通信用のプロパティー
	// --------------------------------------------------------------------

	/// <summary>
	/// 依存関係プロパティーではない普通のプロパティーである Window.Title にバインド
	/// </summary>
	[ObservableProperty]
	public partial String? MyTitle
	{
		get;
		set;
	} = "依存関係プロパティーのテスト";

	/// <summary>
	/// 依存関係プロパティーではない普通のプロパティーである TextBox2.NormalText にバインド
	/// </summary>
	[ObservableProperty]
	public partial String? MyText
	{
		get;
		set;
	} = "テスト";

	// --------------------------------------------------------------------
	// コマンド
	// --------------------------------------------------------------------

	#region ウィンドウタイトル変更ボタンの制御
	[RelayCommand]
	private void ButtonSetWindowTitleClicked()
	{
		try
		{
			MyTitle = $"ウィンドウタイトル変更 {Environment.TickCount}";
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}
	#endregion

	#region テキスト変更ボタンの制御
	[RelayCommand]
	private void ButtonSetNormalTextClicked()
	{
		try
		{
			MyText = $"テキスト変更 {Environment.TickCount}";
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}
	#endregion
}
