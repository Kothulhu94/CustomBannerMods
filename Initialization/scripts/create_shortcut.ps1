$WshShell = New-Object -comObject WScript.Shell
$DesktopPath = [Environment]::GetFolderPath("Desktop")
$ShortcutPath = Join-Path $DesktopPath "Bannerlord BLSE.lnk"
$TargetFile = "e:\Bannerlord_Mods\Initialization\launch_blse.bat"
$IconFile = "D:\SteamLibrary\steamapps\common\Mount & Blade II Bannerlord\bin\Win64_Shipping_Client\Bannerlord.BLSE.Launcher.exe"

$Shortcut = $WshShell.CreateShortcut($ShortcutPath)
$Shortcut.TargetPath = $TargetFile
$Shortcut.WorkingDirectory = "e:\Bannerlord_Mods\Initialization"
$Shortcut.IconLocation = "$IconFile,0"
$Shortcut.Save()

Write-Host "Shortcut created at: $ShortcutPath"
