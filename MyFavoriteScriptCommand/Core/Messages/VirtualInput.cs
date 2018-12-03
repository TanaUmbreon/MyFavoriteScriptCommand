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

            keyMap.Add(ConsoleKey.D0, VirtualKey.Num0);
            keyMap.Add(ConsoleKey.NumPad0, VirtualKey.Num0);
            keyMap.Add(ConsoleKey.D1, VirtualKey.Num1);
            keyMap.Add(ConsoleKey.NumPad1, VirtualKey.Num1);
            keyMap.Add(ConsoleKey.D2, VirtualKey.Num2);
            keyMap.Add(ConsoleKey.NumPad2, VirtualKey.Num2);
            keyMap.Add(ConsoleKey.D3, VirtualKey.Num3);
            keyMap.Add(ConsoleKey.NumPad3, VirtualKey.Num3);
            keyMap.Add(ConsoleKey.D4, VirtualKey.Num4);
            keyMap.Add(ConsoleKey.NumPad4, VirtualKey.Num4);
            keyMap.Add(ConsoleKey.D5, VirtualKey.Num5);
            keyMap.Add(ConsoleKey.NumPad5, VirtualKey.Num5);
            keyMap.Add(ConsoleKey.D6, VirtualKey.Num6);
            keyMap.Add(ConsoleKey.NumPad6, VirtualKey.Num6);
            keyMap.Add(ConsoleKey.D7, VirtualKey.Num7);
            keyMap.Add(ConsoleKey.NumPad7, VirtualKey.Num7);
            keyMap.Add(ConsoleKey.D8, VirtualKey.Num8);
            keyMap.Add(ConsoleKey.NumPad8, VirtualKey.Num8);
            keyMap.Add(ConsoleKey.D9, VirtualKey.Num9);
            keyMap.Add(ConsoleKey.NumPad9, VirtualKey.Num9);
        }

        /// <summary>
        /// ユーザーによって押されたキーを取得します。
        /// </summary>
        /// <returns></returns>
        public VirtualKey GetKey()
        {
            var input = Console.ReadKey(intercept: true);
            VirtualKey key;
            keyMap.TryGetValue(input.Key, out key);
            return key;
        }
    }
}
