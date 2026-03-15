# PowerShell script to package and upload Bannerlord mod to Steam using SteamCMD

param(
    [switch]$WhatIf
)

# Load configuration
$ConfigPath = Join-Path -Path $PSScriptRoot -ChildPath 'steam_upload_config.json'
if (-not (Test-Path $ConfigPath)) {
    Write-Error "Configuration file 'steam_upload_config.json' not found at $ConfigPath"
    exit 1
}
$config = Get-Content $ConfigPath -Raw | ConvertFrom-Json

# Validate required fields
$required = @('steamAppId','steamUsername','steamPassword','modRoot','outputZip','buildScriptPath')
foreach ($field in $required) {
    if (-not $config.$field) {
        Write-Error "Missing required config field: $field"
        exit 1
    }
}

# Resolve paths
$modRoot = Resolve-Path $config.modRoot
$zipPath = Join-Path -Path $modRoot -ChildPath $config.outputZip
$buildScript = Resolve-Path $config.buildScriptPath

# Step 1: Build the mod (optional)
Write-Host "Running build script: $buildScript"
if (-not $WhatIf) {
    & $buildScript
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Build script failed with exit code $LASTEXITCODE"
        exit $LASTEXITCODE
    }
} else {
    Write-Host "-WhatIf: Skipping build script execution"
}

# Step 2: Package the mod into a zip file
Write-Host "Creating zip package at $zipPath"
if (-not $WhatIf) {
    if (Test-Path $zipPath) { Remove-Item $zipPath -Force }
    # Use 7z if available, fallback to Compress-Archive
    if (Get-Command 7z -ErrorAction SilentlyContinue) {
        & 7z a -tzip $zipPath "${modRoot}\*" | Out-Null
    } else {
        Compress-Archive -Path "${modRoot}\*" -DestinationPath $zipPath -Force
    }
} else {
    Write-Host "-WhatIf: Skipping zip creation"
}

# Step 3: Upload via SteamCMD
$steamCmd = "steamcmd.exe"
$steamCmdArgs = @(
    "+login", "$($config.steamUsername)", "$($config.steamPassword)",
    "+run_app_build", "$($config.steamAppId) $zipPath",
    "+quit"
)

Write-Host "Invoking SteamCMD to upload the build"
if (-not $WhatIf) {
    & $steamCmd @steamCmdArgs
    if ($LASTEXITCODE -ne 0) {
        Write-Error "SteamCMD failed with exit code $LASTEXITCODE"
        exit $LASTEXITCODE
    }
} else {
    Write-Host "-WhatIf: Would run: $steamCmd $($steamCmdArgs -join ' ')"
}

Write-Host "Upload process completed."
