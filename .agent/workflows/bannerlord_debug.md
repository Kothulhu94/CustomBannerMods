---
description: Automated Bannerlord Debug Loop
---
# Bannerlord Debug Loop with Turbo Automation

// turbo-all

This workflow automates the debugging process for Bannerlord mods. It assumes the environment is already set up and the game is ready to launch.

1.  **Launch and Verify Stability**:
    Run the stability verification script. This script acts as the "driver" - it launches the game, handles the UI, and then exits, leaving the game running.
    ```powershell
    d:/PortablePython/python.exe ./Tools/verify_game_stability.py
    ```

2.  **Monitor Logs (Manual Step simulated)**:
    In a real scenario, we would loop here. For this workflow, we check the logs.
    ```powershell
    Get-Content logs/Brigands_Terror.log -Tail 5
    ```

3.  **Crash Recovery (Conditional)**:
    If a crash is detected (no log updates), kill the game.
    ```powershell
    taskkill /F /IM Bannerlord.BLSE.Standalone.exe /T
    taskkill /F /IM Bannerlord.Native.exe /T
    ```

4.  **Log Analysis**:
    Dump logs to find the culprit.
    ```powershell
    Get-ChildItem logs | Sort-Object LastWriteTime -Descending | Select-Object Name, LastWriteTime -First 5
    ```

5.  **Build and Deploy**:
    After applying fixes (which requires manual agent intervention for now), deploy the mods.
    ```powershell
    ./Tools/deploy_mods.ps1
    ```
