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
    }
}