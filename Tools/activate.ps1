$DotnetPath = Join-Path $PSScriptRoot "dotnet"
if (-not (Test-Path $DotnetPath)) {
    Write-Error "Dotnet directory not found at $DotnetPath"
    exit 1
}

$PwshPath = Join-Path $PSScriptRoot "pwsh"
if (Test-Path $PwshPath) {
    $env:PATH = "$PwshPath;$env:PATH"
    Write-Host "PowerShell 7 (Portable) Activated" -ForegroundColor Green
    Write-Host "Path: $PwshPath"
}

$env:PATH = "$DotnetPath;$env:PATH"
$env:DOTNET_ROOT = $DotnetPath
Write-Host "Dotnet Environment Activated" -ForegroundColor Green
Write-Host "Path: $DotnetPath"
& "$DotnetPath\dotnet" --version
