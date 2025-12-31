@echo off
:: Wrapper to run ILSpyCmd using the portable .NET 10 SDK with roll-forward enabling
:: Usage: ilspy <arguments>

set "DOTNET_EXE=%~dp0..\..\Tools\dotnet\dotnet.exe"
:: Find the DLL dynamically if possible, or hardcode relative path based on install
set "ILSPY_DLL=%~dp0..\..\Tools\decompiler\.store\ilspycmd\9.1.0.7988\ilspycmd\9.1.0.7988\tools\net8.0\any\ilspycmd.dll"

"%DOTNET_EXE%" --roll-forward Major "%ILSPY_DLL%" %*
