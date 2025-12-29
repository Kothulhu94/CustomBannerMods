param (
    [Parameter(Mandatory = $true)]
    [string]$ModName
)

$ModulesDir = Join-Path $PSScriptRoot "..\Modules"
$ModDir = Join-Path $ModulesDir $ModName
$BinDir = Join-Path $ModDir "bin\Win64_Shipping_Client"

if (Test-Path $ModDir) {
    Write-Error "Module $ModName already exists at $ModDir"
    exit 1
}

New-Item -ItemType Directory -Path $ModDir | Out-Null
New-Item -ItemType Directory -Path $BinDir -Force | Out-Null

# 1. Create .csproj (Minimal, thanks to Directory.Build.props)
$csprojContent = @"
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <AssemblyName>$ModName</AssemblyName>
  </PropertyGroup>
</Project>
"@
Set-Content -Path "$ModDir\$ModName.csproj" -Value $csprojContent

# 2. Create SubModule.xml
$guid = [guid]::NewGuid().ToString()
$xmlContent = @"
<Module>
    <Name value="$ModName"/>
    <Id value="$guid"/>
    <Version value="1.0.0"/>
    <SingleplayerModule value="true"/>
    <MultiplayerModule value="false"/>
    <Internal value="false"/>
    <DependedModules>
        <DependedModule Id="Native"/>
        <DependedModule Id="SandBoxCore"/>
        <DependedModule Id="Sandbox"/>
        <DependedModule Id="StoryMode"/>
        <DependedModule Id="CustomBattle"/>
    </DependedModules>
    <SubModules>
        <SubModule>
            <Name value="$ModName"/>
            <DLLName value="$ModName.dll"/>
            <SubModuleClassType value="$ModName.${ModName}SubModule"/>
            <Tags>
                <Tag key="DedicatedServerType" value="none" />
                <Tag key="IsNoRenderModeElement" value="false" />
            </Tags>
        </SubModule>
    </SubModules>
    <Xmls/>
</Module>
"@
Set-Content -Path "$ModDir\SubModule.xml" -Value $xmlContent

# 3. Create Main SubModule.cs
$csContent = @"
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using System;
using System.IO;

namespace $ModName
{
    public class ${ModName}SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            DebugLogger.Log("${ModName} Loaded");
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage("${ModName} Active"));
        }
    }

    public static class DebugLogger
    {
         // Auto-generated logger pointing to workspace logs
         private static string LogPath => Path.Combine(@"$($ModulesDir | Split-Path)\logs", "${ModName}.log");
         
         public static void Log(string message) {
            try {
                File.AppendAllText(LogPath, $"[{DateTime.Now}] {message}{Environment.NewLine}");
            } catch {}
         }
    }
}
"@
Set-Content -Path "$ModDir\${ModName}SubModule.cs" -Value $csContent

Write-Host "Created Module '$ModName' in $ModDir" -ForegroundColor Green
Write-Host "Try building it: dotnet build Modules/$ModName"
