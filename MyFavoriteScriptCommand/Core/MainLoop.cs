namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンの実行環境を実装したアプリケーションのメイン ループです。
    /// </summary>
    public class MainLoop : ISceneContext
    {
        /// <summary>
        /// 次に実行するシーンのセットを取得または設定します。
        /// </summary>
        public ISceneSet NextSceneSet { get; set; }

        /// <summary>
        /// <see cref="MainLoop"/> の新しいインスタンスを生成します。
        /// </summary>
        public MainLoop() { }

        /// <summary>
        /// メイン ループを実行します。
        /// </summary>
        /// <remarks>
        /// このメソッドを呼び出す前に <see cref="SetNext"/> メソッドで最初に実行するシーンを設定する必要があります。
        /// </remarks>
        public void Run()
        {
            while (NextSceneSet != null)
            {
                NextSceneSet.NextScene(this);
            }
        }

        /// <summary>
        /// 現在呼び出されているシーン実行メソッドが終了した後にアプリケーションを終了します。
        /// </summary>
        public void Quit()
        {
            NextSceneSet = null;
        }
    }
}
