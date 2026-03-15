$libs = "d:\Bannerlord_Mods\libs"
$files = @("TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $files) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Find-Members($typeName, $pattern) {
    Write-Output "--- $typeName ($pattern) ---"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetMembers() | Where-Object { $_.Name -match $pattern } | ForEach-Object { $_.ToString() }
    }
}

Find-Members "TaleWorlds.CampaignSystem.Settlements.Settlement" "Position"
Find-Members "TaleWorlds.CampaignSystem.Settlements.Settlement" "GetPosition"
Find-Members "TaleWorlds.CampaignSystem.Settlements.Village" "Villager"
Find-Members "TaleWorlds.CampaignSystem.Party.PartyBase" "Strength"
Find-Members "TaleWorlds.CampaignSystem.Party.MobileParty" "Position"
