$DotnetPath = Join-Path $PSScriptRoot "dotnet"
if (-not (Test-Path $DotnetPath)) {
    Write-Error "Dotnet directory not found at $DotnetPath"
    exit 1
}

$env:PATH = "$DotnetPath;$env:PATH"
$env:DOTNET_ROOT = $DotnetPath
Write-Host "Dotnet Environment Activated" -ForegroundColor Green
Write-Host "Path: $DotnetPath"
& "$DotnetPath\dotnet" --version
