namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーンの実行環境 (メイン ループ) によって呼び出されるシーン実行メソッドの参照です。
    /// </summary>
    /// <param name="context"></param>
    public delegate void SceneCallback(ISceneContext context);
}
