$git = "e:\PortableGit\cmd\git.exe"
$modulesDir = "e:\Bannerlord_Mods\Modules"

Set-Location $modulesDir

# Remove everything from index
& $git rm -r --cached .

# Re-add everything (respecting new .gitignore)
& $git add .

& $git commit -m "Cleanup: Add .gitignore and remove binaries"

& $git push origin main
