using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// 仮想化した入力デバイスです。
    /// </summary>
    public class VirtualInput
    {
        /// <summary>コンソールの標準キーに対応する仮想キーのキー マッピング</summary>
        private Dictionary<ConsoleKey, VirtualKey> keyMap = new Dictionary<ConsoleKey, VirtualKey>();

        /// <summary>
        /// <see cref="VirtualInput"/> の新しいインスタンスを生成します。
        /// </summary>
        public VirtualInput()
        {
            // キーマッピングを作成する
            keyMap.Add(ConsoleKey.Escape, VirtualKey.Quit);
            keyMap.Add(ConsoleKey.Enter, VirtualKey.Commit);
            keyMap.Add(ConsoleKey.Backspace, VirtualKey.Cancel);
            keyMap.Add(ConsoleKey.UpArrow, VirtualKey.Up);
            keyMap.Add(ConsoleKey.DownArrow, VirtualKey.Down);
        }

        /// <summary>
        /// ユーザーによって押されたキーを取得します。
        /// </summary>
        /// <returns></returns>
        public VirtualKey GetKey()
        {
            var input = Console.ReadKey(intercept: true);
            keyMap.TryGetValue(input.Key, out var key);
            return key;
        }
    }
}
