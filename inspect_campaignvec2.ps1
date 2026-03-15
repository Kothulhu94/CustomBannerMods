$libs = "d:\Bannerlord_Mods\libs"
[System.Reflection.Assembly]::LoadFrom((Join-Path $libs "TaleWorlds.Library.dll")) | Out-Null
$type = [TaleWorlds.Library.CampaignVec2]
$type.GetMembers() | ForEach-Object { $_.ToString() }
