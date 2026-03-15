$libs = "d:\Bannerlord_Mods\libs"
$targetDlls = @("TaleWorlds.Library.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($file in $targetDlls) {
    [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $file)) | Out-Null
}

function Find-PosProps($typeName) {
    Write-Output "--- $typeName ---"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetProperties() | Where-Object { $_.PropertyType.Name -match 'Vec2' } | ForEach-Object { "$($_.Name) -> $($_.PropertyType.Name)" }
    }
}

Find-PosProps "TaleWorlds.CampaignSystem.Party.MobileParty"
Find-PosProps "TaleWorlds.CampaignSystem.Settlements.Settlement"
