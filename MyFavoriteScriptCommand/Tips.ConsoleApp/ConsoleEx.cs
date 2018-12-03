using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Tips.ConsoleApp
{
    /// <summary>
    /// コンソール アプリケーションの拡張的な機能を提供します。
    /// </summary>
    public static class ConsoleEx
    {
        #region メソッド

        /// <summary>
        /// 指定した時間が経過するもしくは、ユーザーが任意のキーを押すまでプログラムを待機します。
        /// </summary>
        /// <param name="milliseconds">待機する時間 (ミリ秒単位)。</param>
        public static void Timeout(long milliseconds)
        {
            Timeout(TimeSpan.FromMilliseconds(milliseconds));
        }

        /// <summary>
        /// 指定した時間が経過するもしくは、ユーザーが任意のキーを押すまでプログラムを待機します。
        /// </summary>
        /// <param name="timeout">待機する時間を表す <see cref="TimeSpan"/> 構造体。</param>
        public static void Timeout(TimeSpan timeout)
        {
            Console.Write(string.Format("{0:0} 秒待っています。続行するには何かキーを押してください ...", timeout.TotalSeconds));

            // キー入力待機は入力されるまで処理が止まるので、別のスレッドで行う
            PressedKey = false;
            Task.Run(() =>
            {
                Console.ReadKey(intercept: true);
                PressedKey = true;
            });

            // 時間経過待機は呼び出し元のスレッド上で行う
            var timer = Stopwatch.StartNew();
            while (timer.Elapsed < timeout && !PressedKey)
            {
                Thread.Sleep(SleepInterval);
            }

            Console.WriteLine();
        }

        #endregion

        #region フィールド

        /// <summary>クラス単位でスレッドを排他制御するためのオブジェクト</summary>
        private static readonly object StaticLock = new object();
        /// <summary>待機ループの終了条件を確認する待機間隔</summary>
        private static readonly TimeSpan SleepInterval = TimeSpan.FromMilliseconds(50);

        #endregion

        #region プロパティ

        /// <summary>
        /// ユーザーによってキー入力されたことを示す値を取得または設定します。
        /// このプロパティはスレッド セーフです。
        /// </summary>
        private static bool PressedKey {
            get
            {
                lock (StaticLock)
                {
                    return _pressedKey;
                }
            }
            set
            {
                lock (StaticLock)
                {
                    _pressedKey = value;
                }
            }
        }

        private static bool _pressedKey = false;

        #endregion
    }
}
