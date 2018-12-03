namespace MyFavoriteScriptCommand.Core.Messages
{
    /// <summary>
    /// 仮想キーを表します。
    /// </summary>
    public enum VirtualKey
    {
        // Dictionary.TryGetValueでの規定値として利用している
        /// <summary>キー未入力。</summary>
        None = 0,

        /// <summary>強制終了キー。</summary>
        Quit,
        /// <summary>決定キー。</summary>
        Commit,
        /// <summary>キャンセル キー。</summary>
        Cancel,
        /// <summary>↑キー。</summary>
        Up,
        /// <summary>↓キー。</summary>
        Down,

        /// <summary>0 キー。</summary>
        Num0,
        /// <summary>1 キー。</summary>
        Num1,
        /// <summary>2 キー。</summary>
        Num2,
        /// <summary>3 キー。</summary>
        Num3,
        /// <summary>4 キー。</summary>
        Num4,
        /// <summary>5 キー。</summary>
        Num5,
        /// <summary>6 キー。</summary>
        Num6,
        /// <summary>7 キー。</summary>
        Num7,
        /// <summary>8 キー。</summary>
        Num8,
        /// <summary>9 キー。</summary>
        Num9,
    }
}