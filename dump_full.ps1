$libs = "d:\Bannerlord_Mods\libs"
$files = @("TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $files) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Dump-Full($typeName) {
    Write-Output "#### $typeName ####"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetMembers([System.Reflection.BindingFlags]"Public,NonPublic,Instance,Static,FlattenHierarchy") | ForEach-Object {
            $_.ToString()
        }
    }
}

Dump-Full "TaleWorlds.CampaignSystem.Party.MobileParty"
Dump-Full "TaleWorlds.CampaignSystem.Settlements.Settlement"
Dump-Full "TaleWorlds.CampaignSystem.Settlements.Village"
Dump-Full "TaleWorlds.Library.CampaignVec2"
Dump-Full "TaleWorlds.Library.Vec2"
