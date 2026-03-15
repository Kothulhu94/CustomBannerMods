$git = "e:\PortableGit\cmd\git.exe"
$root = "e:\Bannerlord_Mods"
$remoteUrl = "https://github.com/Kothulhu94/CustomBannerMods.git"

Set-Location $root

# 1. Access the Root Repo
if (-not (Test-Path ".git")) {
    & $git init
}

# 2. Configure Remote
& $git remote remove origin
& $git remote add origin $remoteUrl

# 3. Consolidate Modules (Remove nested repo if exists)
if (Test-Path "Modules/.git") {
    Write-Host "Removing nested git in Modules to unify repo..."
    Remove-Item -Path "Modules/.git" -Recurse -Force
}

# 4. Create Root .gitignore
$gitignore = @(
    ".git/"
    ".vscode/"
    "bin/"
    "obj/"
    "logs/"
    "*.log"
    "*.user"
    "*.suo"
    "test_reflection.txt"
    # Ignore standard game modules and libraries
    "Modules/Bannerlord.*"
    "Modules/Native"
    "Modules/SandBox*"
    "Modules/StoryMode"
    "Modules/CustomBattle"
    "Modules/BirthAndDeath"
)
$gitignore | Out-File ".gitignore" -Encoding utf8

# 5. Stage Files
# User requested: Initialization, Tools, scripts, GEMINI.md
# And we must preserve the custom mods we pushed earlier (now in Modules/)

& $git add .gitignore
& $git add GEMINI.md
& $git add Initialization/
& $git add Tools/
& $git add scripts/

# Add Custom Mods (The .gitignore handles the exclusions of libs, so we can add Modules/)
& $git add Modules/

# 6. Commit and Push
& $git commit -m "Migrate to Monorepo: Add Tools, Init, Scripts, and structural restructure"

Write-Host "Pushing to remote (Force required due to structure change)..."
# We force push because we are replacing the 'Modules-only' root with 'Workspace' root
& $git push --force -u origin main
