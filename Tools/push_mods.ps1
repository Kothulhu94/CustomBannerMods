$git = "e:\PortableGit\cmd\git.exe"
$modulesDir = "e:\Bannerlord_Mods\Modules"

Set-Location $modulesDir

& $git init
& $git config user.email "agent@antigravity.dev"
& $git config user.name "Antigravity Agent"

# Check if remote exists, remove if so (to be safe/idempotent)
& $git remote remove origin
& $git remote add origin https://github.com/Kothulhu94/CustomBannerMods.git

# fetch to see if main exists or we need to branch
# & $git fetch origin # This might fail if auth is needed immediately, skipping for now.

# Add Custom Mods
$mods = @("BetterGov", "Brigands", "CoastalLife", "FieldSquire", "HappyParty", "HonestWork", "Landlord", "LivingLegend", "LudusMagnus", "NewClans", "Directory.Build.props")

foreach ($mod in $mods) {
    if (Test-Path $mod) {
        & $git add $mod
    } else {
        Write-Host "Warning: $mod not found."
    }
}

& $git commit -m "Snapshot of custom mods"

Write-Host "Attempting push..."
& $git branch -M main
& $git push -u origin main
