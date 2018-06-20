using System;

namespace MyFavoriteScriptCommand
{
    /// <summary>
    /// ビッパのねがいごとを表します。
    /// </summary>
    class Wish : IChoice
    {
        /// <summary>ねがいごと叶える時に呼び出されるメソッド</summary>
        private Action action;

        /// <summary>
        /// ねがいごとの内容を取得します。
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// <see cref="Wish"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="content">ねがいごとの内容。</param>
        /// <param name="action">ねがいごと叶える時に呼び出されるメソッド。</param>
        public Wish(string content, Action action)
        {
            Content = content;
            this.action = action;
        }

        /// <summary>
        /// ねがいごとを叶えます。
        /// </summary>
        public void Grant() => action.Invoke();
    }
}
