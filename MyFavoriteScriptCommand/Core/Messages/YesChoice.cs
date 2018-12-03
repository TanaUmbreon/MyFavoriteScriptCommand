using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// 「はい」の選択肢を表します。
    /// </summary>
    public class YesChoice : Choice
    {
        /// <summary>
        /// 「はい」を表す既定のメッセージ。
        /// </summary>
        private const string DefaultMessage = "はい";

        /// <summary>
        /// 指定した遷移先のシーンと、既定のメッセージを使用して
        /// <see cref="YesChoice"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="nextScene">選択した時に遷移する次のシーン実行メソッド。</param>
        public YesChoice(SceneCallback nextScene) :
            this(DefaultMessage, nextScene)
        { }

        /// <summary>
        /// 指定した代替メッセージと遷移先のシーンで
        /// <see cref="YesChoice"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="message">選択肢に表示する「はい」を表す代替メッセージ。</param>
        /// <param name="nextScene">選択した時に遷移する次のシーン実行メソッド。</param>
        public YesChoice(string message, SceneCallback nextScene) :
            base(message, nextScene)
        { }
    }
}
