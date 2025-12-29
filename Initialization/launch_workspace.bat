:: Get the absolute path to the initialization directory (where this script is)
cd /d "%~dp0"
set "INIT_DIR=%~dp0"
:: Get the workspace root (one level up)
pushd "%INIT_DIR%.."
set "WORKSPACE_ROOT=%CD%"
popd

set "DOTNET_DIR=%INIT_DIR%dotnet_portable"
set "BIN_DIR=%INIT_DIR%bin"
set "SCRIPTS_DIR=%INIT_DIR%scripts"

echo ==================================================
echo      Antigravity Portable Workspace Launcher
echo ==================================================
echo Workspace Root: %WORKSPACE_ROOT%
echo DotNet Root:    %DOTNET_DIR%

:: Set environment variables for the portable .NET SDK
set "DOTNET_ROOT=%DOTNET_DIR%"
set "PATH=%DOTNET_DIR%;%BIN_DIR%;%PATH%"

:: Launch the AutoHotkey Window Manager
if exist "%BIN_DIR%\AutoHotkey.exe" (
    set "AHK_EXE=%BIN_DIR%\AutoHotkey.exe"
    goto LaunchAHK
)
if exist "%BIN_DIR%\AutoHotkey64.exe" (
    set "AHK_EXE=%BIN_DIR%\AutoHotkey64.exe"
    goto LaunchAHK
)
if exist "%BIN_DIR%\AutoHotkey32.exe" (
    set "AHK_EXE=%BIN_DIR%\AutoHotkey32.exe"
    goto LaunchAHK
)

:: If locally not found, try system association
echo AutoHotkey executable not found in bin. Attempting system association...
start "" "%SCRIPTS_DIR%\overlay_manager.ahk"
goto AHKDone

:LaunchAHK
echo Launching Window Manager (AHK)...
start "" "%AHK_EXE%" "%SCRIPTS_DIR%\overlay_manager.ahk"

:AHKDone

:: Launch the Antigravity IDE (Dynamic Location)
set "CONFIG_FILE=%INIT_DIR%ide_path_%COMPUTERNAME%.txt"
set "IDE_PATH="

if exist "%CONFIG_FILE%" (
    echo Reading configuration from: %CONFIG_FILE%
    set /p IDE_PATH=<"%CONFIG_FILE%"
)

if defined IDE_PATH (
    echo IDE Path found: "%IDE_PATH%"
    if exist "%IDE_PATH%" goto LaunchIDE
    echo Saved IDE path does not exist: "%IDE_PATH%"
)

:PromptIDE
echo.
echo [SETUP REQUIRED] Antigravity IDE executable location unknown for %COMPUTERNAME%.
echo Please drag and drop the Antigravity IDE executable here and press Enter:
set /p "IDE_PATH="
:: Remove quotes if present
set "IDE_PATH=%IDE_PATH:"=%"

if not exist "%IDE_PATH%" (
    echo [ERROR] Path does not exist: "%IDE_PATH%"
    pause
    goto PromptIDE
)

:: Save path for next time
echo %IDE_PATH%> "%CONFIG_FILE%"

:LaunchIDE
:: Generate mcp_servers.json for Antigravity
echo Generating Dynamic MCP Configuration...
set "MCP_CONFIG=%WORKSPACE_ROOT%\mcp_servers.json"
set "CLI_SERVER=%WORKSPACE_ROOT%\tools\mcp_servers\cli\server.py"

:: Detect Portable Python
set "PYTHON_EXE=python"
if exist "%~d0\ppy\python.exe" (
    echo [INFO] Found Portable Python in ppy folder.
    set "PYTHON_EXE=%~d0\ppy\python.exe"
)

:: Build Rogue Researcher
echo Building Rogue Researcher...
dotnet build "%WORKSPACE_ROOT%\tools\mcp_servers\rogue_researcher" >nul 2>&1
if %ERRORLEVEL% NEQ 0 (
    echo [WARNING] Rogue Researcher build failed.
) else (
    echo Rogue Researcher built successfully.
)

:: Escape paths for JSON
set "DOTNET_JSON=%DOTNET_DIR:\=\\%\\dotnet.exe"
set "ROGUE_PROJECT_JSON=%WORKSPACE_ROOT:\=\\%\\tools\\mcp_servers\\rogue_researcher"
set "PYTHON_JSON=%PYTHON_EXE:\=\\%"

:: Escape backslashes for JSON
set "CLI_SERVER_JSON=%CLI_SERVER:\=\\%"

:: Create the JSON content
(
    echo {
    echo   "mcpServers": {
    echo     "commander": {
    echo       "command": "%PYTHON_JSON%",
    echo       "args": ["%CLI_SERVER_JSON%"],
    echo       "env": {
    echo         "PYTHONUNBUFFERED": "1"
    echo       }
    echo     },
    echo     "rogue-researcher": {
    echo       "command": "%DOTNET_JSON%",
    echo       "args": ["run", "--project", "%ROGUE_PROJECT_JSON%"]
    echo     }
    echo   }
    echo }
) > "%MCP_CONFIG%"

echo MCP Configuration written to: %MCP_CONFIG%

echo Launching Antigravity IDE...
start "" "%IDE_PATH%"

echo.
echo Launch sequence initiated. You may close this window.
timeout /t 5 >nul
goto :eof

:Error
echo.
echo [ERROR] An unexpected error occurred.
pause
