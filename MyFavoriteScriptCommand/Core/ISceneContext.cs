namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンの実行環境を提供します。
    /// </summary>
    public interface ISceneContext
    {
        /// <summary>
        /// 現在のシーンを取得または設定します。
        /// </summary>
        IScene CurrentScene { get; set; }
    }
}
