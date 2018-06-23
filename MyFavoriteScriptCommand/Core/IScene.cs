namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// ゲームのシーンを実装します。
    /// </summary>
    public interface IScene
    {
        /// <summary>
        /// シーン実行ループを抜けてアプリケーションを終了できること示す値を取得します。
        /// </summary>
        bool CanExit { get; }

        /// <summary>
        /// シーンを実行します。
        /// </summary>
        /// <param name="context">シーンの実行環境。</param>
        void Run(ISceneContext context);
    }
}
