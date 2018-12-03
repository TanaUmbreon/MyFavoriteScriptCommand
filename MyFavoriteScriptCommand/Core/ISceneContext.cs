namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンの実行環境を提供します。
    /// </summary>
    public interface ISceneContext
    {
        /// <summary>
        /// 次に実行するシーンのセットを取得または設定します。
        /// </summary>
        ISceneSet NextSceneSet { get; set; }

        /// <summary>
        /// 現在呼び出されているシーン実行メソッドが終了した後にアプリケーションを終了します。
        /// </summary>
        void Quit();
    }
}
