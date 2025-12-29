@echo off
set "DOTNET_EXE=%~dp0..\..\dotnet\dotnet.exe"
set "TOOL_DLL=%~dp0bin\Debug\net8.0\rogue_researcher.dll"

"%DOTNET_EXE%" --roll-forward Major "%TOOL_DLL%" %*
