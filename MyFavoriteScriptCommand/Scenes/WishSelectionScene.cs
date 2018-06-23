using System;
using System.Collections.Generic;
using System.Linq;
using MyFavoriteScriptCommand.Core;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// ねがいごとを選択するシーンです。
    /// </summary>
    public class WishSelectionScene : IScene
    {
        public bool CanExit { get; set; } = false;

        public void Run(ISceneContext context)
        {
            Console.WriteLine("ビッパ「あっしの ねがいごとは……えーと……");
            Console.WriteLine("エート……");
            var wishes = new List<Wish>()
            {
                new Wish(content:"おかねに なりたい!", nextScene:new NotImplementedScene("なんだ! よくだらけじゃないか!")),
                new Wish(content:"さいきょうベトベタスイッチ", nextScene:new NotImplementedScene("ホラーが はっせいしました")),
                new Wish(content:"いかを みればいいのか!", nextScene:new NotImplementedScene("そこはかとなく しずめてみよう……")),
                new Wish(content:"おいしいもちに なりたい!", nextScene:new NotImplementedScene("んで もやしたってワケ♪")),
                new Wish(content:"ひたすら デバッグ", nextScene:new NotImplementedScene("いっしょう デバッグ")),
                new Wish(content:"どうぐあつかい", nextScene:new NotImplementedScene("リサイクルしちゃうぞー!")),
                new Wish(content:"ふざけるなッ! ヨノワール!", nextScene:new SelectedDoNotBeSillyDusknoirScene()),
            };

            Wish selectedWish = Select(wishes, "ねがいごとを えらんでください");
            context.CurrentScene = selectedWish.NextScene;
        }

        /// <summary>
        /// 指定した選択肢のコレクションからユーザーが選択した選択肢を返します。
        /// </summary>
        /// <typeparam name="T">選択肢の型。</typeparam>
        /// <param name="choices">選択肢のコレクション。</param>
        /// <param name="message">入力を促すためのメッセージ。</param>
        /// <returns>ユーザーが選択した選択肢。</returns>
        /// <exception cref="OperationCanceledException">ユーザーがエスケープ キーを入力した時に発生します。</exception>
        private T Select<T>(List<T> choices, string message) where T : IChoice
        {
            foreach (var choice in choices.Select((c, i) => new { Value = c, Index = i }))
            {
                Console.WriteLine($"  {choice.Index}: {choice.Value.Content}");
            }
            Console.WriteLine();

            Console.WriteLine(message);
            while (true)
            {
                var input = Console.ReadKey(intercept: true);
                if (input.Key == ConsoleKey.Escape) throw new OperationCanceledException();

                if (!Int32.TryParse(input.KeyChar.ToString(), out int index)) continue;
                if (index < 0 || index >= choices.Count) continue;

                return choices[index];
            }
        }
    }
}
