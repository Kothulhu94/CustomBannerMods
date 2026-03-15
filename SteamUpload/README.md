# Steam Upload Automation

This folder contains scripts and configuration to package and upload the mod to Steam using SteamCMD.

## Prerequisites
- SteamCMD installed and accessible in your PATH.
- 7z (or any zip utility) for packaging the mod.
- PowerShell 7 (portable) available at `./Tools/pwsh/pwsh.exe`.

## Usage
1. Edit `steam_upload_config.json` with your Steam credentials and app ID.
2. Run the PowerShell script:
   ```powershell
   ./SteamUpload/upload_mod.ps1
   ```
   Use `-WhatIf` to perform a dry‑run without uploading.
3. The script will create a zip of the mod and invoke SteamCMD to upload it.

## Notes
- Keep `steam_upload_config.json` secure; do not commit it to source control.
- The script supports headless execution for automation.
