using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// メッセージ ウィンドウを操作します。
    /// </summary>
    public static class MessageWindow
    {
        #region 文字色

        /// <summary>
        /// 通常テキストの文字色を取得します。
        /// </summary>
        private static ConsoleColor TextColor { get; } = ConsoleColor.White;

        /// <summary>
        /// カーソルの文字色を取得します。
        /// </summary>
        private static ConsoleColor CorsorColor { get; } = ConsoleColor.Yellow;

        #endregion

        /// <summary>
        /// メッセージ ウィンドウをクリアして、指定したメッセージを表示します。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        private static void InternalShow(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
            
            Console.Clear();
            Console.Write(message);
        }

        /// <summary>
        /// 指定したメッセージを表示します。ユーザーがキーを入力するまで処理を待機します。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        public static void Show(string message)
        {
            InternalShow(message);

            var input = new VirtualInput();
            while (true)
            {
                switch (input.GetKey())
                {
                    case VirtualKey.Commit:
                        return;
                    case VirtualKey.Quit:
                        throw new OperationCanceledException();
                }
            }
        }

        #region ShowChoices

        /// <summary>
        /// 指定した選択肢の一覧を表示し、ユーザーが選択した選択肢を返します。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        /// <param name="choices">表示する選択肢の一覧。</param>
        /// <returns>ユーザーが選択した選択肢を返します。</returns>
        public static Choice ShowChoices(string message, params Choice[] choices)
        {
            if (choices == null) throw new ArgumentNullException(nameof(choices));
            if (!choices.Any()) throw new ArgumentException("選択肢が一つもありません。", nameof(choices));

            InternalShow(message);

            var cursor = new CursorController(choices);
            var input = new VirtualInput();

            while (true)
            {
                foreach (var choice in choices)
                {
                    Console.WriteLine(choice.Message);
                }

                switch (input.GetKey())
                {
                    case VirtualKey.Down:
                        cursor.Down();
                        break;
                    case VirtualKey.Up:
                        cursor.Up();
                        break;
                    case VirtualKey.Commit:
                        return cursor.CurrentOption;
                    case VirtualKey.Quit:
                        throw new OperationCanceledException();
                }
            }
        }
        
        /// <summary>
        /// 選択肢のカーソル操作を行います。
        /// </summary>
        private class CursorController
        {
            private LinkedList<CursorItem> items;

            /// <summary>
            /// 選択中の選択肢を取得します。
            /// </summary>
            public Choice CurrentOption { get; private set; }

            /// <summary>
            /// <see cref="CursorController"/> の新しいインスタンスを生成します。
            /// </summary>
            /// <param name="options">表示する選択肢の一覧。</param>
            public CursorController(IEnumerable<Choice> options)
            {
                items = new LinkedList<CursorItem>(options.Select(o => new CursorItem()));
            }

            internal void Up()
            {
                throw new NotImplementedException();
            }

            internal void Down()
            {
                throw new NotImplementedException();
            }
        }

        private class CursorItem
        {


            public CursorItem()
            {

            }
        }

        #endregion
    }
}