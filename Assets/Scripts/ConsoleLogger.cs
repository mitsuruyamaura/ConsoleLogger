using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

/// <summary>
/// Debug.Log メソッドのラップ用ヘルパークラス
/// Unity Console ビューでダブルクリックした際にログ元のコードにジャンプ(リダイレクト)できる
/// 
/// ラップした Debug.Log メソッドをダブルクリックした際にログ元にジャンプするようにするには
/// クラス名を ～ Logger で終わるようにし、かつ、メソッド名を Log とすることで実現可能
/// 例えば DebugLogger、LogHelperLogger など
/// 
/// Helper class for wrapping Debug.Log method.
/// Allows jumping (redirecting) to the source code of the log entry by double-clicking in the Unity Console view.
/// 
/// To enable jumping to the source code when double-clicking the wrapped Debug.Log method,
/// ensure the class name ends with "Logger" and the method name is "Log".
/// Examples include DebugLogger and LogHelperLogger.
/// </summary>
public static class ConsoleLogger {

    /// <summary>
    /// Console ビューでダブルクリックした際に、このメソッドではなく、ログ元のコードへジャンプする Log メソッド
    /// DefineSymbol に DEBUG を含めることで、デバッグビルド時にも動作する
    /// </summary>
    /// <param name="value">ログに出力する値</param>
    /// <param name="filePath">ログ出力元のファイルパス</param>
    /// <param name="memberName">ログ出力元のメソッド名</param>
    /// <param name="lineNumber">ログ出力元の行番号</param>
    /// 
    /// Log method that redirects to the source code instead of this method when double-clicking in the Console view.
    /// Works in debug builds by including DEBUG in the Define Symbols.
    /// </summary>
    /// <param name="value">The value to output in the log.</param>
    /// <param name="filePath">The file path of the log source.</param>
    /// <param name="memberName">The method name of the log source.</param>
    /// <param name="lineNumber">The line number of the log source.</param>
    [Conditional("DEBUG")]
    public static void Log(object value, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) {
        // valueが null なら "null" を代入
        // Assign "null" if value is null
        value ??= "null";

        // 呼び出し元のファイルと行番号を付ける
        // Append source file and line number to the log message
        string message = $" {value} \n [{Path.GetFileName(filePath)}:{lineNumber} ({memberName})]";

        // ログ表示
        // Display the log message
        UnityEngine.Debug.Log(message?.ToString());
    }
}