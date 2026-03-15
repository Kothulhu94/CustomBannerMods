$libs = "d:\Bannerlord_Mods\libs"
$dlls = @("TaleWorlds.Library.dll", "TaleWorlds.CampaignSystem.dll")
foreach ($dll in $dlls) { [System.Reflection.Assembly]::LoadFrom((Join-Path $libs $dll)) | Out-Null }

function Clean-Dump($typeName) {
    Write-Output "#### $typeName ####"
    $type = [AppDomain]::CurrentDomain.GetAssemblies().ForEach({$_.GetType($typeName)}).Where({$_})[0]
    if ($type) {
        $type.GetMembers() | ForEach-Object { "$($_.MemberType): $($_.Name)" }
    }
}

Clean-Dump "TaleWorlds.Library.CampaignVec2"
Clean-Dump "TaleWorlds.CampaignSystem.Settlements.Settlement"
Clean-Dump "TaleWorlds.CampaignSystem.Party.MobileParty"
