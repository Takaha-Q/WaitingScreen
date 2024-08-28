using PreCommit_RR;
using System.Windows;
using System.Windows.Threading;

namespace Util;
/// <summary>
/// WaitingScreen.xaml の相互作用ロジック
/// </summary>
public partial class WaitingScreen : Window
{
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // private フィールド
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// 現在表示中のファイル番号
    /// </summary>
    private int fileNum = 0;

    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // コンストラクタ・ファイナライザ
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public WaitingScreen( string message = "処理中です…" )
    {
        InitializeComponent();

        DataContext = MainViewModel.Instance;

        MainViewModel.Instance.Message.Value = message;
        ReNewImgPath();

        // 表示更新用タイマの設定、起動
        DispatcherTimer timer = new DispatcherTimer();
        timer.Interval = new TimeSpan( 500000 );
        timer.Tick += ( s, e ) => ReNewImgPath();

        Loaded += (s, e) => timer.Start();
    }

    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // private メソッド
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    /// <summary>
    /// 画像の更新
    /// </summary>
    /// <remarks>タイマ発火時にコールされることを想定</remarks>
    private void ReNewImgPath()
    {
        fileNum++;
        if( fileNum > 24 )
        {
            fileNum = 1;
        }

        ( (MainViewModel)DataContext ).Path_Img.Value = $@"_img\{fileNum:000}.png";
    }

}
