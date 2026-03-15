param(
    [Parameter(Mandatory = $true)]
    [string]$TypeName,
    [string]$MemberPattern = ".*",
    [switch]$NonPublic,
    [switch]$Exact
)

# Bannerlord Reflection Search Tool
# Unified replacement for scan_*.ps1 and search_*.ps1 scripts.

$ErrorActionPreference = "Stop"
$root = "d:\Bannerlord_Mods"
$libs = Join-Path $root "libs"

# Core DLLs to load for reflection
$files = @(
    "TaleWorlds.Library.dll",
    "TaleWorlds.Core.dll",
    "TaleWorlds.Localization.dll",
    "TaleWorlds.CampaignSystem.dll",
    "TaleWorlds.CampaignSystem.ViewModelCollection.dll",
    "TaleWorlds.ObjectSystem.dll",
    "TaleWorlds.MountAndBlade.dll",
    "TaleWorlds.MountAndBlade.ViewModelCollection.dll",
    "TaleWorlds.Engine.dll",
    "TaleWorlds.InputSystem.dll",
    "SandBox.dll",
    "NavalDLC.dll"
)

foreach ($file in $files) {
    $path = Join-Path $libs $file
    if (Test-Path $path) {
        try {
            [System.Reflection.Assembly]::LoadFrom($path) | Out-Null
        }
        catch {
            Write-Warning "Failed to load $file"
        }
    }
}

$type = $null
# Search through all loaded assemblies for the type
foreach ($a in [AppDomain]::CurrentDomain.GetAssemblies()) {
    $type = $a.GetType($TypeName)
    if ($type) { break }
}

if (-not $type) {
    Write-Error "Type '$TypeName' not found in loaded assemblies."
    return
}

Write-Host "`n[TYPE] $($type.FullName)" -ForegroundColor Cyan
Write-Host "Assembly: $($type.Assembly.GetName().Name)" -ForegroundColor Gray

$flags = [System.Reflection.BindingFlags]"Public,Instance,Static,FlattenHierarchy"
if ($NonPublic) { $flags = $flags -bor [System.Reflection.BindingFlags]"NonPublic" }

$members = $type.GetMembers($flags)

$results = $members | Where-Object { 
    if ($Exact) { $_.Name -eq $MemberPattern }
    else { $_.Name -match $MemberPattern }
}

if ($results) {
    Write-Host "`nFound $($results.Count) matches for '$MemberPattern':" -ForegroundColor Green
    foreach ($m in $results) {
        $sig = ""
        if ($m.MemberType -eq "Method") {
            $params = $m.GetParameters() | ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }
            $sig = "$($m.ReturnType.Name) $($m.Name)($($params -join ', '))"
        }
        elseif ($m.MemberType -eq "Property") {
            $getSet = ""
            if ($m.CanRead) { $getSet += "get; " }
            if ($m.CanWrite) { $getSet += "set; " }
            $sig = "$($m.PropertyType.Name) $($m.Name) { $getSet}"
        }
        elseif ($m.MemberType -eq "Field") {
            $sig = "$($m.FieldType.Name) $($m.Name)"
        }
        else {
            $sig = "$($m.MemberType): $($m.Name)"
        }
        
        $scope = if ($m.IsPublic) { "public" } else { "private/internal" }
        Write-Host "  [$scope] $sig"
    }
}
else {
    Write-Host "No members matching '$MemberPattern' found." -ForegroundColor Yellow
}
