using System;
using MyFavoriteScriptCommand.Core;

namespace MyFavoriteScriptCommand
{
    /// <summary>
    /// ビッパのねがいごとを表します。
    /// </summary>
    class Wish : IChoice
    {
        /// <summary>
        /// ねがいごとの内容を取得します。
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// 遷移する次のシーンを取得します。
        /// </summary>
        public IScene NextScene { get; }

        /// <summary>
        /// <see cref="Wish"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="content">ねがいごとの内容。</param>
        /// <param name="nextScene">選択した時に遷移する次のシーン。</param>
        public Wish(string content, IScene nextScene)
        {
            Content = content;
            NextScene = nextScene;
        }
    }
}
