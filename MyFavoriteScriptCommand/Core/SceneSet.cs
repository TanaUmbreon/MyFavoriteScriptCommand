namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンのセットを実装した基底クラスです。
    /// <see cref="ISceneSet"/> インターフェース
    /// </summary>
    public abstract class SceneSet : ISceneSet
    {
        /// <summary>
        /// 次のシーン実行で呼び出されるメソッドの参照を取得します。
        /// </summary>
        public SceneCallback NextScene { get; protected set; }
    }
}
