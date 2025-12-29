@echo off
echo Launching Bannerlord BLSE...

:: Target Configuration
set "GAME_DIR=D:\SteamLibrary\steamapps\common\Mount & Blade II Bannerlord\bin\Win64_Shipping_Client"
set "EXE_NAME=Bannerlord.BLSE.Launcher.exe"

:: Verify executable exists
if not exist "%GAME_DIR%\%EXE_NAME%" (
    echo [ERROR] Could not find BLSE Launcher at:
    echo %GAME_DIR%\%EXE_NAME%
    echo.
    echo Please verify that the path matches your installation.
    pause
    exit /b 1
)

:: Change working directory and launch
cd /d "%GAME_DIR%"
start "" "%EXE_NAME%"

:: Close this window
exit
