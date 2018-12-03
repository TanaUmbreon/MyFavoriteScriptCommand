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
        /// <summary>
        /// メッセージ ウィンドウをクリアして、指定したメッセージを表示します。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        private static void InternalShow(string message)
        {
            if (message == null) throw new ArgumentNullException("message");
            
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

        /// <summary>
        /// 指定した選択肢の一覧を表示し、ユーザーが選択した選択肢を返します。
        /// </summary>
        /// <param name="message">表示するメッセージ。</param>
        /// <param name="choices">表示する選択肢の一覧。</param>
        /// <returns>ユーザーが選択した選択肢を返します。</returns>
        public static Choice ShowChoices(string message, params Choice[] choices)
        {
            if (choices == null) { throw new ArgumentNullException("choices"); }
            if (!choices.Any()) { throw new ArgumentException("選択肢が一つもありません。", "choices"); }

            const int MaxChoicesCount = 9;
            int count = choices.Count();
            if (count > MaxChoicesCount) { throw new ArgumentException("選択肢の上限は 9 つまでです。"); }

            InternalShow(message);
            Console.WriteLine();

            // 選択肢のキー番号は 1 始まりとする
            foreach (var choice in choices.Select((c, i) => new { Value = c, Index = i + 1 }))
            {
                Console.WriteLine(string.Format("  {0}: {1}", choice.Index, choice.Value.Message));
            }

            var input = new VirtualInput();
            while (true)
            {
                switch (input.GetKey())
                {
                    // ↓クソみたいなハードコードだけどいい子は真似しちゃダメだぞ☆
                    case VirtualKey.Num1:
                        if (count > 0) { return choices[0]; }
                        break;
                    case VirtualKey.Num2:
                        if (count > 1) { return choices[1]; }
                        break;
                    case VirtualKey.Num3:
                        if (count > 2) { return choices[2]; }
                        break;
                    case VirtualKey.Num4:
                        if (count > 3) { return choices[3]; }
                        break;
                    case VirtualKey.Num5:
                        if (count > 4) { return choices[4]; }
                        break;
                    case VirtualKey.Num6:
                        if (count > 5) { return choices[5]; }
                        break;
                    case VirtualKey.Num7:
                        if (count > 6) { return choices[6]; }
                        break;
                    case VirtualKey.Num8:
                        if (count > 7) { return choices[7]; }
                        break;
                    case VirtualKey.Num9:
                        if (count > 8) { return choices[8]; }
                        break;

                    case VirtualKey.Quit:
                        throw new OperationCanceledException();
                }
            }
        }
    }
}