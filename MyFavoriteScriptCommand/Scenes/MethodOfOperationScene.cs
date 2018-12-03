using MyFavoriteScriptCommand.Core;
using MyFavoriteScriptCommand.Core.Messages;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// 操作方法を説明するシーンのセットです。
    /// </summary>
    public class MethodOfOperationScene : SceneSet
    {
        /// <summary>
        /// <see cref="MethodOfOperationScene"/> の新しいインスタンスを生成します。
        /// </summary>
        public MethodOfOperationScene()
        {
            NextScene = Scene1;
        }

        private void Scene1(ISceneContext context)
        {
            // ↑メソッドなのに動詞で始まらないクソみたいなネーミング。
            //   良い名前が思いつかなかったのはもしかして……
            //   ダークライの しわざです。

            MessageWindow.Show(
                "------------------------\n" +
                "だいすきなSCRIPT_COMMAND\n" +
                "------------------------\n" +
                "【操作方法】\n" +
                "決定    : Enterキー\n" +
                "選択肢  : 数字キー\n" +
                "強制終了: Escキー\n" +
                "\n" +
                "決定キーを押すと続行します..."
                );

            context.NextSceneSet = new WishSelectionScene();
        }
    }
}
