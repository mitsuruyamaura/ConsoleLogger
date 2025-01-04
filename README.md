このクラスは、`Debug.Log` をラップしてログ出力を行い、リリースビルドにはログを含めません。(Unity エディター上と DEBUG の DefineSymbol を含めたときだけログ出力されます。)

また、Unity の Console ビューで表示されたログメッセージをダブルクリックすると、ラップ先ではなく、ログの出力元となったコードの行にジャンプできる機能を提供します。

ログ出力には、ファイル名、行番号、メソッド名などの情報も自動的に付加します。

デバッグ作業を効率化し、コードのどの部分からログが出力されたのかを素早く確認できます。
