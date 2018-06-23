using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteScriptCommand.Core
{
    /// <summary>
    /// シーン実行ループを提供します。
    /// </summary>
    public class SceneLoop : ISceneContext
    {
        /// <summary>
        /// 現在のシーンを取得または設定します。
        /// </summary>
        public IScene CurrentScene { get; set; } = null;

        /// <summary>
        /// <see cref="SceneLoop"/> の新しいインスタンスを生成します。
        /// </summary>
        public SceneLoop() { }

        /// <summary>
        /// シーン実行ループを実行します。
        /// </summary>
        public void Run()
        {
            while (CurrentScene != null && !CurrentScene.CanExit)
            {
                CurrentScene.Run(this);
            }
        }
    }
}
