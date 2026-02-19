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
	} = "テキスト";

	/// <summary>
	/// 依存関係プロパティーである TextBox2.KeyDownInfo にバインド
	/// </summary>
	[ObservableProperty]
	public partial String? MyKeyDownInfo
	{
		get;
		set;
	} = "キー入力情報";

	/// <summary>
	/// 依存関係プロパティーの中継
	/// </summary>
	[ObservableProperty]
	public partial String? MyRelayText
	{
		get;
		set;
	} = "依存関係プロパティーの中継";

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

	#region 依存関係プロパティーの中継
	[RelayCommand]
	private void ButtonRelayClicked()
	{
		try
		{
			MyRelayText = $"中継テキスト変更 {Environment.TickCount}";
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
		}
	}
	#endregion
}
