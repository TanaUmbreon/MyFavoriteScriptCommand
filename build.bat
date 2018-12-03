@echo off

echo ビルドを開始します。

:: NuGet パッケージを復元するソリューション ファイル
set TargetSolution=MyFavoriteScriptCommand.sln
:: ビルドするプロジェクト ファイル
set TargetProject=MyFavoriteScriptCommand\MyFavoriteScriptCommand.csproj
:: ビルド生成物の出力先フォルダ (※ %TargetProject% が起点)
set OutputPath=..\bin\MyFavoriteScriptCommand

:: .NET Framework 4.x のコンパイラ
set Compiler=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe

cd /d %~dp0

if not exist "%Compiler%" (
	echo.
	echo .NET Framework 4.x のコンパイラが見つかりません。

	goto BREAK
)

echo.
echo プロジェクトをビルドします。
echo.
"%Compiler%" "%TargetProject%" /p:Configuration=Release;OutputPath="%OutputPath%";PostBuildEvent="del /q *.xml /q *.exe.config"
:: Releaseビルド、出力先指定、ビルド後に.xmlファイルを全て削除している

echo.
pause
goto EOF

:BREAK
echo.
echo ビルドを中断しました。
pause