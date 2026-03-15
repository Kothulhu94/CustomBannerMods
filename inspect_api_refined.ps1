$libs = "d:\Bannerlord_Mods\libs"
$files = @("TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $files) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Find-PropertyByType($typeName, $targetTypeName) {
    Write-Output "Searching properties in $typeName that return $targetTypeName"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetProperties() | Where-Object { $_.PropertyType.Name -match $targetTypeName } | ForEach-Object { "$($_.Name) -> $($_.PropertyType.FullName)" }
    }
}

function Find-MethodBySignature($typeName, $methodName) {
    Write-Output "Searching for method $methodName in $typeName"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetMethods() | Where-Object { $_.Name -eq $methodName } | ForEach-Object { $_.ToString() }
    }
}

Find-PropertyByType "TaleWorlds.Library.CampaignVec2" "Vec2"
Find-PropertyByType "TaleWorlds.CampaignSystem.Settlements.Settlement" "CampaignVec2"
Find-PropertyByType "TaleWorlds.CampaignSystem.Party.MobileParty" "Vec2"
Find-MethodBySignature "TaleWorlds.CampaignSystem.Party.MobileParty" "SetMoveGoToSettlement"
Find-MethodBySignature "TaleWorlds.CampaignSystem.Party.MobileParty" "SetMovePatrolAroundSettlement"
Find-PropertyByType "TaleWorlds.CampaignSystem.Settlements.Village" "MobileParty"
Find-PropertyByType "TaleWorlds.CampaignSystem.Settlements.Village" "Party"
