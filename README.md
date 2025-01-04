このクラスは、`Debug.Log` をラップしてログ出力を行い、リリースビルドにはログを含めません。(Unity エディター上と DEBUG の DefineSymbol を含めたときだけログ出力されます。)

また、Unity の Console ビューで表示されたログメッセージをダブルクリックすると、ラップ先ではなく、ログの出力元となったコードの行にジャンプできる機能を提供します。

ログ出力には、ファイル名、行番号、メソッド名などの情報も自動的に付加します。

デバッグ作業を効率化し、コードのどの部分からログが出力されたのかを素早く確認できます。

----

This class wraps Debug.Log to output logs and excludes logs from release builds.
(Logs are output only when running in the Unity Editor or when the DEBUG define symbol is included.)

Additionally, it provides a feature that allows you to double-click the log message in Unity's Console view to jump directly to the line of code where the log was output, instead of jumping to the wrapper method.

Log output automatically includes information such as the file name, line number, and method name.

This class streamlines debugging tasks, enabling quick identification of the code section that generated the log.
