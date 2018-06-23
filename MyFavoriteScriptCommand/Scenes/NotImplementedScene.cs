using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFavoriteScriptCommand.Core;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// 未実装のシーンです。
    /// </summary>
    public class NotImplementedScene : IScene
    {
        private string errorMessage;

        public bool CanExit { get; set; } = false;

        /// <summary>
        /// <see cref="NotImplementedScene"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="errorMessage">例外として通知するエラー メッセージ。</param>
        public NotImplementedScene(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        public void Run(ISceneContext context)
        {
            throw new NotImplementedException(errorMessage);
        }
    }
}
