$libs = "d:\Bannerlord_Mods\libs"
$dlls = @("TaleWorlds.Library.dll", "TaleWorlds.Core.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($dll in $dlls) { try { [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $dll)) | Out-Null } catch { Write-Host "Failed to load $dll" } }

function Get-TypeMembers($typeName) {
    Write-Host "`n==== $typeName ===="
    $type = $null
    foreach ($a in [AppDomain]::CurrentDomain.GetAssemblies()) {
        $type = $a.GetType($typeName)
        if ($type) { break }
    }
    if (-not $type) {
        Write-Host "TYPE NOT FOUND"
        return
    }
    
    $type.GetProperties() | ForEach-Object {
        "P: $($_.Name) ($($_.PropertyType.Name))"
    } | Sort-Object
    
    $type.GetMethods() | ForEach-Object {
        $params = $_.GetParameters() | ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }
        "M: $($_.ReturnType.Name) $($_.Name)($($params -join ', '))"
    } | Sort-Object
}

Get-TypeMembers "TaleWorlds.Library.CampaignVec2"
Get-TypeMembers "TaleWorlds.CampaignSystem.Settlements.Settlement"
Get-TypeMembers "TaleWorlds.CampaignSystem.Party.MobileParty"
Get-TypeMembers "TaleWorlds.CampaignSystem.Party.PartyBase"
Get-TypeMembers "TaleWorlds.CampaignSystem.Settlements.Village"
