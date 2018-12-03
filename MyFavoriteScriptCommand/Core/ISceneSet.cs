namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンのセットを実装します。
    /// </summary>
    public interface ISceneSet
    {
        /// <summary>
        /// 次のシーン実行で呼び出されるメソッドの参照を取得します。
        /// </summary>
        SceneCallback NextScene { get; }
    }
}
