# だいすきなSCRIPT_COMMAND

降って湧いたネタプログラム。はにわ氏のヒテリス作品「バケモン混沌のダンジョン 罵愚の探検隊」から。

## ダウンロードと実行方法

1. [ダウンロード ページ](https://github.com/TanaUmbreon/MyFavoriteScriptCommand/releases)から最新バージョンの「MyFavoriteScriptCommand-bin-*x*.*x*.*x*.zip」をダウンロードします。
2. ダウンロードした ZIP ファイルを展開して「MyFavoriteScriptCommand.exe」を実行します。

## スクリーンショット

### 実行画面

![](https://raw.githubusercontent.com/TanaUmbreon/MyFavoriteScriptCommand/images/Exe1.png)
![](https://raw.githubusercontent.com/TanaUmbreon/MyFavoriteScriptCommand/images/Exe2.png)

### ソースコード

![](https://raw.githubusercontent.com/TanaUmbreon/MyFavoriteScriptCommand/images/Source.png)

## 動作環境

Windows 10 ならそのまま問題なく動くはずです。  
それ以外の Windows OS だと .NET Framework 4.5.2 がインストールされていれば動くと思いますが、最新の Windows Update を適用しているならば動くはずだと思うので .NET Framework のインストール方法は割愛します(単なる手抜き)。

## プログラムの作成方法 (おまけ)

1. [ダウンロード ページ](https://github.com/TanaUmbreon/MyFavoriteScriptCommand/releases)から **バージョン 2.0.0 移行** のソースコード「Source code (zip)」をダウンロードします。
2. ダウンロードした ZIP ファイルを展開して「build.bat」をダブルクリックして実行します。
3. コンソール画面に「ビルドに成功しました。」のメッセージが表示されたら成功です。何かキーを押してコンソールを閉じます。  
(エラーが発生した場合は……すまない、対策を考えていないんだ……)
4. ビルドに成功すると「bin」というフォルダが作成され、そのフォルダの一番奥に「MyFavoriteScriptCommand.exe」が作成されます。  
このファイルがソースコードから作成されたプログラムになります。

### ソースコード (表示するメッセージなど) のいじり方

ソースコードの言語 (C#) についての説明は割愛するので、読めることを前提としています。

* "MyFavoriteScriptCommand" フォルダの "Scenes" フォルダにある "*xxx*Scene.cs" というファイルをメモ帳などで開いてソースコードを編集するだけです。
  * 編集後、再度ビルドしてソースコードに問題がなければ変更したプログラムが作成されます。
* 新しいシーンのセットを追加する場合、新しいファイル ("*xxx*Scene.cs") を追加してもそのままではビルド対象に含まれないので注意してください。
  * ファイル内にクラスを複数記述した方が簡単です。
  * "MyFavoriteScriptCommand.csproj" の中身も編集すればビルド対象に含まれるようになりますが手動での編集は少しややこしいのでお勧めできません。
* 他のフォルダにあるソースコードはこのプログラムの裏で動くコアな処理なので、不用意に変更するとめちゃくちゃになる可能性があるので注意。
