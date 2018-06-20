using System;
using System.Collections.Generic;
using System.Linq;
using Tips.ConsoleApp;

namespace MyFavoriteScriptCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine();
                Console.WriteLine("操作はキャンセルされました");
            }
            finally
            {
                ConsoleEx.Timeout(milliseconds:10000);
            }
        }

        private static void Run()
        {
            Console.WriteLine("ビッパ「あっしの ねがいごとは……えーと……");
            Console.WriteLine("エート……");
            var wishes = new List<Wish>()
                {
                    new Wish(content:"おかねに なりたい!", action:() => throw new NotImplementedException("なんだ! よくだらけじゃないか!")),
                    new Wish(content:"さいきょうベトベタスイッチ", action:() => throw new NotImplementedException("ホラーが はっせいしました")),
                    new Wish(content:"いかを みればいいのか!", action:() => throw new NotImplementedException("そこはかとなく しずめてみよう……")),
                    new Wish(content:"おいしいもちに なりたい!", action:() => throw new NotImplementedException("んで もやしたってワケ♪")),
                    new Wish(content:"ひたすら デバッグ", action:() => throw new NotImplementedException("いっしょう デバッグ")),
                    new Wish(content:"どうぐあつかい", action:() => throw new NotImplementedException("リサイクルしちゃうぞー!")),
                    new Wish(content:"ふざけるなッ! ヨノワール!", action:DoNotBeSillyDusknoir),
                };
            Wish selectedWish = Select(wishes, "ねがいごとを えらんでください");

            selectedWish.Grant();
        }

        private static void DoNotBeSillyDusknoir()
        {
            Console.WriteLine();
            Console.WriteLine("だが そんな てに ひっかかる");
            Console.WriteLine("オレたちじゃないぜッ!");
            Console.WriteLine("> はい");
            Console.WriteLine("  いいえ");
            Console.ReadKey(intercept: true);

            Console.WriteLine();
            Console.WriteLine("ホントに ホェェェェェェェッ!!");
            Console.WriteLine("> はい");
            Console.WriteLine("  いいえのさばくの まもりがみ!");
            Console.ReadKey(intercept: true);

            Console.WriteLine();
            Console.WriteLine("以降の実装は消えてなくなりました。");
            Console.WriteLine("これ ダークライの しわざです。");
            Console.WriteLine();
        }

        /// <summary>
        /// 指定した選択肢のコレクションからユーザーが選択した選択肢を返します。
        /// </summary>
        /// <typeparam name="T">選択肢の型。</typeparam>
        /// <param name="choices">選択肢のコレクション。</param>
        /// <param name="message">入力を促すためのメッセージ。</param>
        /// <returns>ユーザーが選択した選択肢。</returns>
        /// <exception cref="OperationCanceledException">ユーザーがエスケープ キーを入力した時に発生します。</exception>
        private static T Select<T>(List<T> choices, string message) where T : IChoice
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
