# Workspace Cleanup Utility
# Removes temporary research outputs and decompiled scripts from the root directory.

$root = "d:\Bannerlord_Mods"
$keepFiles = @(
    "build_log.txt",
    "GEMINI.md",
    "foldersummary.toon",
    "mcp_servers.json",
    ".gitignore"
)

Write-Host "Starting Workspace Cleanup..." -ForegroundColor Cyan

# 1. Get all files to potentially remove
$files = Get-ChildItem -Path $root -File

foreach ($file in $files) {
    # Only target research-like extensions
    if ($file.Extension -notmatch "txt|log|cs|ps1|md") { continue }
    
    if ($keepFiles -contains $file.Name) {
        Write-Host "  [KEEP] $($file.Name)" -ForegroundColor Gray
        continue
    }

    # Don't delete scripts that should be moved
    if ($file.Name -eq "package_mod.ps1") {
        Write-Host "  [SKIP] $($file.Name) - Manual migration required" -ForegroundColor Yellow
        continue
    }

    try {
        Remove-Item $file.FullName -Force
        Write-Host "  [REMOVED] $($file.Name)" -ForegroundColor Red
    }
    catch {
        Write-Warning "Could not remove $($file.Name): $_"
    }
}

Write-Host "`nCleanup Complete." -ForegroundColor Green
