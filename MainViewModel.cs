using Reactive.Bindings;

namespace PreCommit_RR;

/// <summary>
/// 共通 ViewModel
/// </summary>
/// <remarks>
/// シングルトン
/// </remarks>
class MainViewModel
{
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // public プロパティ
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// MainViewModel のインスタンスを取得する
    /// </summary>
    public static MainViewModel Instance { get; } = new();

    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // public プロパティ (Reactive)
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// 表示画像のパス
    /// </summary>
    public ReactivePropertySlim<string> Path_Img { get; } = new ReactivePropertySlim<string>();

    /// <summary>
    /// 表示するテキスト
    /// </summary>
    public ReactivePropertySlim<string> Message { get; } = new ReactivePropertySlim<string>();

    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // コンストラクタ・ファイナライザ
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// [private] コンストラクタ
    /// </summary>
    private MainViewModel() 
    {
    }

    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // public メソッド
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

}
