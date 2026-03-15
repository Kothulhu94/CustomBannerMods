$libs = "d:\Bannerlord_Mods\libs"
$targetDlls = @("TaleWorlds.Library.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $targetDlls) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Dump-Members($typeName) {
    Write-Output "--- $typeName ---"
    $type = $null
    foreach ($a in [AppDomain]::CurrentDomain.GetAssemblies()) {
        $type = $a.GetType($typeName)
        if ($type) { break }
    }
    if ($type) {
        $type.GetMembers() | ForEach-Object {
            $name = $_.Name
            if ($_.MemberType -eq 'Property') {
                Write-Output "P: $name ($($_.PropertyType.Name))"
            } elseif ($_.MemberType -eq 'Method') {
                $params = $_.GetParameters() | ForEach-Object { "$($_.ParameterType.Name)" }
                Write-Output "M: $name ($($params -join ', ')) -> $($_.ReturnType.Name)"
            }
        }
    } else {
        Write-Output "NOT FOUND"
    }
}

Dump-Members "TaleWorlds.Library.CampaignVec2"
Dump-Members "TaleWorlds.CampaignSystem.Settlements.Settlement"
Dump-Members "TaleWorlds.CampaignSystem.Party.MobileParty"
