@echo off

echo �r���h���J�n���܂��B

:: NuGet �p�b�P�[�W�𕜌�����\�����[�V���� �t�@�C��
set TargetSolution=MyFavoriteScriptCommand.sln
:: �r���h����v���W�F�N�g �t�@�C��
set TargetProject=MyFavoriteScriptCommand\MyFavoriteScriptCommand.csproj
:: �r���h�������̏o�͐�t�H���_ (�� %TargetProject% ���N�_)
set OutputPath=..\bin\MyFavoriteScriptCommand

:: .NET Framework 4.x �̃R���p�C��
set Compiler=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe

cd /d %~dp0

if not exist "%Compiler%" (
	echo.
	echo .NET Framework 4.x �̃R���p�C����������܂���B

	goto BREAK
)

echo.
echo �v���W�F�N�g���r���h���܂��B
echo.
"%Compiler%" "%TargetProject%" /p:Configuration=Release;OutputPath="%OutputPath%";PostBuildEvent="del /q *.xml /q *.exe.config"
:: Release�r���h�A�o�͐�w��A�r���h���.xml�t�@�C����S�č폜���Ă���

echo.
pause
goto EOF

:BREAK
echo.
echo �r���h�𒆒f���܂����B
pause