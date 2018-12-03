namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// 選択肢を表します。
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// 選択肢のメッセージを取得します。
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// 選択した時に遷移する次のシーン実行メソッドを取得します。
        /// </summary>
        public SceneCallback NextScene { get; }

        /// <summary>
        /// <see cref="Choice"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="message">選択肢のメッセージ。</param>
        /// <param name="nextScene">選択した時に遷移する次のシーン実行メソッド。</param>
        public Choice(string message, SceneCallback nextScene)
        {
            Message = message;
            NextScene = nextScene;
        }
    }
}
