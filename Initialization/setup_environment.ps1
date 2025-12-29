$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$WorkspaceRoot = Join-Path $ScriptDir ".."
$ToolsDir = Join-Path $WorkspaceRoot "Tools"
$DestDir = Join-Path $ScriptDir "dotnet_portable"

Write-Host "Setting up portable environment..."
Write-Host "Source Tools: $ToolsDir"
Write-Host "Destination: $DestDir"

# Ensure destination exists
if (-not (Test-Path $DestDir)) {
    New-Item -ItemType Directory -Path $DestDir -Force | Out-Null
}

# 1. Search for .NET 10 SDK Archive (Zip)
$Archive = Get-ChildItem -Path $ToolsDir -Filter "dotnet-sdk*10*.zip" -Recurse | Select-Object -First 1

if ($Archive) {
    Write-Host "Found .NET archive: $($Archive.FullName)"
    Write-Host "Extracting..."
    Expand-Archive -Path $Archive.FullName -DestinationPath $DestDir -Force
} else {
    # 2. Check for existing 'dotnet' directory
    $ExistingDotnet = Join-Path $ToolsDir "dotnet"
    if (Test-Path $ExistingDotnet) {
        Write-Host "Archive not found, but pre-extracted 'dotnet' folder found in Tools."
        Write-Host "Copying contents to dotnet_portable..."
        Copy-Item -Path "$ExistingDotnet\*" -Destination $DestDir -Recurse -Force
    } else {
        Write-Warning "Could not find .NET 10 header archive or 'dotnet' folder in Tools."
        Write-Warning "Please manually place the .NET SDK in Initialization/dotnet_portable"
    }
}

Write-Host "Environment setup complete."
