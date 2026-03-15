$libs = "d:\Bannerlord_Mods\libs"
$targetDlls = @("TaleWorlds.Library.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $targetDlls) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Dump-Properties($typeName) {
    Write-Output "--- $typeName ---"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetProperties() | ForEach-Object {
            Write-Output "P: $($_.Name) ($($_.PropertyType.Name))"
        }
    }
}

Dump-Properties "TaleWorlds.CampaignSystem.Settlements.Settlement"
Dump-Properties "TaleWorlds.CampaignSystem.Party.MobileParty"
Dump-Properties "TaleWorlds.CampaignSystem.Party.PartyBase"
Dump-Properties "TaleWorlds.Library.CampaignVec2"
