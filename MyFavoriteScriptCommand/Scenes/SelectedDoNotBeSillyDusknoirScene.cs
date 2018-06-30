using System;
using MyFavoriteScriptCommand.Core;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// ねがいごとで「ふざけるなッ! ヨノワール!」を選択した後のシーンです。
    /// </summary>
    public class SelectedDoNotBeSillyDusknoirScene : Scene
    {
        public override void Run(ISceneContext context)
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

            CanExit = true;
        }
    }
}