using System;
using MyFavoriteScriptCommand.Core;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// 未実装のシーンです。
    /// </summary>
    public class NotImplementedScene : Scene
    {
        private string errorMessage;

        /// <summary>
        /// <see cref="NotImplementedScene"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="errorMessage">例外として通知するエラー メッセージ。</param>
        public NotImplementedScene(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        public override void Run(ISceneContext context)
        {
            throw new NotImplementedException(errorMessage);
        }
    }
}
