$libs = "d:\Bannerlord_Mods\libs"
$files = @("TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $files) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Inspect-Type($typeName) {
    Write-Output "=== $typeName ==="
    $type = $null
    foreach ($a in [AppDomain]::CurrentDomain.GetAssemblies()) {
        $type = $a.GetType($typeName)
        if ($type) { break }
    }
    if (-not $type) {
        Write-Output "NOT FOUND"
        return
    }
    $type.GetMembers() | ForEach-Object {
        $sig = $_.ToString()
        Write-Output $sig
    }
}

Inspect-Type "TaleWorlds.CampaignSystem.Party.PartyBase"
Inspect-Type "TaleWorlds.CampaignSystem.Party.MobileParty"
Inspect-Type "TaleWorlds.CampaignSystem.Settlements.Settlement"
Inspect-Type "TaleWorlds.CampaignSystem.Settlements.Village"
Inspect-Type "TaleWorlds.Library.CampaignVec2"
Inspect-Type "TaleWorlds.Library.Vec2"
