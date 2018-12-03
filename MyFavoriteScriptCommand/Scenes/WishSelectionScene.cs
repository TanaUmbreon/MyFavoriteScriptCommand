using System;
using System.Collections.Generic;
using System.Linq;
using MyFavoriteScriptCommand.Core;
using MyFavoriteScriptCommand.Core.Messages;

namespace MyFavoriteScriptCommand.Scenes
{
    /// <summary>
    /// ねがいごとを選択するシーンです。
    /// </summary>
    public class WishSelectionScene : SceneSet
    {
        /// <summary>
        /// <see cref="WishSelectionScene"/> の新しいインスタンスを生成します。
        /// </summary>
        public WishSelectionScene()
        {
            NextScene = Scene1;
        }

        private void Scene1(ISceneContext context)
        {
            var selected = MessageWindow.ShowChoices(
                "ビッパ「あっしの ねがいごとは……えーと……\n" +
                "エート……",
                new Choice(message: "おかねに なりたい!",         nextScene: c => ThrowException("なんだ! よくだらけじゃないか!")),
                new Choice(message: "さいきょうベトベタスイッチ", nextScene: c => ThrowException("ホラーが はっせいしました")),
                new Choice(message: "いかを みればいいのか!",     nextScene: c => ThrowException("そこはかとなく しずめてみよう……")),
                new Choice(message: "おいしいもちに なりたい!",   nextScene: c => ThrowException("んで もやしたってワケ♪")),
                new Choice(message: "ひたすら デバッグ",          nextScene: c => ThrowException("いっしょう デバッグ")),
                new Choice(message: "どうぐあつかい",             nextScene: c => ThrowException("リサイクルしちゃうぞー!")),
                new Choice(message: "ふざけるなッ! ヨノワール!",  nextScene: Scene2)
                );

            NextScene = selected.NextScene;
        }

        private void Scene2(ISceneContext context)
        {
            var selected = MessageWindow.ShowChoices(
                "だが そんな てに ひっかかる\n" +
                "オレたちじゃないぜッ!",
                new YesChoice(nextScene: Scene3),
                new NoChoice(nextScene: Scene2)
                );

            NextScene = selected.NextScene;
        }

        private void Scene3(ISceneContext context)
        {
            var selected = MessageWindow.ShowChoices(
                "ホントに ホェェェェェェェッ!!",
                new YesChoice(nextScene: Scene4),
                new NoChoice(message: "いいえのさばくの まもりがみ!", nextScene: Scene3)
                );

            NextScene = selected.NextScene;
        }

        private void Scene4(ISceneContext context)
        {
            MessageWindow.Show(
                "以降の実装は消えてなくなりました。\n" +
                "これ ダークライの しわざです。\n"
                );

            context.Quit();
        }

        /// <summary>
        /// 未実装の例外 (<see cref="NotImplementedException"/>) を発生させます。
        /// </summary>
        /// <param name="message">例外の原因を説明するエラー メッセージ。</param>
        private void ThrowException(string message)
        {
            throw new NotImplementedException(message);
        }
    }
}
