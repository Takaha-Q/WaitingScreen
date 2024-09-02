     ＿＿＿＿＿＿＿＿
   ／＿＿＿＿＿＿＿＿＼
 ／／                ＼＼
< <   WaitingScreen    > >
 ＼＼＿＿＿＿＿＿＿＿／／
   ＼＿＿＿＿＿＿＿＿／

- = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

○このクラス Util.WaitingScreen について

  時間がかかる処理の際に、処理中である旨を表示する待機画面です。
  モードレスウィンドウとして表示されることを前提としています。

○コンストラクタ

  public WaitingScreen( string message = "処理中です…", Window? owner = null )
  
  message : 画面に表示したいメッセージ
  owner   : オーナーウィンドウ
            (設定しない場合は減じあのアクティブウィンドウをオーナーとする)

○使用例

/// <summary>
/// 時間のかかる処理を含むメソッド
/// </summary>
internal static async void HeavyWorkSuger()
{
    try
    {
        // 待機画面表示
        WaitingScreen waiting = new ( "しばらくお待ちください…" );
        waiting.Show();

        // 時間のかかる処理
        // (await)
        await Task.Run( () => HeavyWork() );

        // 待機画面を閉じる
        waiting.Close();
    }
    catch( Exception ex )
    {
        :
    }
}
