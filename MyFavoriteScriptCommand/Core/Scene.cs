namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// ゲームのシーンを表す基底クラスです。
    /// <see cref="IScene"/> インターフェース
    /// </summary>
    public abstract class Scene : IScene
    {
        /// <summary>
        /// シーン実行ループを抜けてアプリケーションを終了できること示す値を取得します。
        /// </summary>
        public bool CanExit { get; set; } = false;

        /// <summary>
        /// シーンを実行します。
        /// </summary>
        /// <param name="context">シーンの実行環境。</param>
        public abstract void Run(ISceneContext context);
    }
}
