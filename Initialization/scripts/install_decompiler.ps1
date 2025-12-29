$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$WorkspaceRoot = Join-Path $ScriptDir "..\.."
$DotNetDir = Join-Path $WorkspaceRoot "Initialization\dotnet_portable"
$DotNetExe = Join-Path $DotNetDir "dotnet.exe"
$DecompilerDir = Join-Path $WorkspaceRoot "Tools\decompiler"

# Ensure dotnet portable exists
if (-not (Test-Path $DotNetExe)) {
    Write-Error "Portable .NET SDK not found at $DotNetExe. Please run setup_environment.ps1 first."
    exit 1
}

Write-Host "Installing ILSpyCmd to $DecompilerDir..."

# Install ilspycmd
& $DotNetExe tool install ilspycmd --tool-path $DecompilerDir

if ($LASTEXITCODE -eq 0) {
    Write-Host "ILSpyCmd installed successfully."
} else {
    Write-Warning "Installation failed or tool might already be installed."
}
