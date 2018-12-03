using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// 「いいえ」の選択肢を表します。
    /// </summary>
    public class NoChoice : Choice
    {
        /// <summary>
        /// 「いいえ」を表す既定のメッセージ。
        /// </summary>
        private const string DefaultMessage = "いいえ";

        /// <summary>
        /// 指定した遷移先のシーンと、既定のメッセージを使用して
        /// <see cref="NoChoice"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="nextScene">選択した時に遷移する次のシーン実行メソッド。</param>
        public NoChoice(SceneCallback nextScene) :
            this(DefaultMessage, nextScene)
        { }

        /// <summary>
        /// 指定した代替メッセージと遷移先のシーンで
        /// <see cref="NoChoice"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="message">選択肢に表示する「いいえ」を表す代替メッセージ。</param>
        /// <param name="nextScene">選択した時に遷移する次のシーン実行メソッド。</param>
        public NoChoice(string message, SceneCallback nextScene) :
            base(message, nextScene)
        { }
    }
}
