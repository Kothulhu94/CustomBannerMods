import os
import sys
import urllib.request
import subprocess

def main():
    """
    Portable PowerShell 7 (Core) Updater
    ------------------------------------
    Downloads and runs the official Microsoft install-powershell.ps1 script.
    Installs to <Workspace>/Tools/pwsh (Portable).
    Does NOT require Admin privileges.
    """
    
    # 1. Setup Paths
    script_dir = os.path.dirname(os.path.abspath(__file__))
    # Tools/Maintenance -> Tools/
    tools_root = os.path.dirname(script_dir) 
    target_dir = os.path.join(tools_root, "pwsh")
    
    installer_url = "https://aka.ms/install-powershell.ps1"
    temp_installer_name = "install_pwsh_temp.ps1"
    installer_path = os.path.join(script_dir, temp_installer_name)
    
    print(f"--- Portable PowerShell Updater ---")
    print(f"Target Directory: {target_dir}")
    
    # 2. Download Installer
    print(f"[INFO] Downloading installer from {installer_url}...")
    try:
        # standard timeout to avoid hanging
        with urllib.request.urlopen(installer_url, timeout=30) as response, open(installer_path, 'wb') as out_file:
            data = response.read()
            out_file.write(data)
        print("[SUCCESS] Installer downloaded.")
    except Exception as e:
        print(f"[ERROR] Failed to download installer: {e}")
        # Fallback: check if curl is available (from Git)
        print("[INFO] Attempting fallback to 'curl'...")
        try:
            subprocess.run(["curl", "-L", "-o", installer_path, installer_url], check=True)
            print("[SUCCESS] content downloaded via curl.")
        except Exception as curl_e:
            print(f"[ERROR] Curl fallback also failed: {curl_e}")
            sys.exit(1)

    # 3. Execute Installer (using System PowerShell)
    # We explicitly avoid -AddToPath as it might trigger admin requirements for registry
    # We presume 'powershell' is in the path (Windows default v5.1)
    
    # Note: access to the script might be needed.
    cmd = [
        "powershell",
        "-NoProfile",
        "-ExecutionPolicy", "Bypass",
        "-File", installer_path,
        "-Destination", target_dir
    ]
    
    print(f"[INFO] Executing installation script...")
    print(f"Command: {' '.join(cmd)}")
    
    try:
        subprocess.run(cmd, check=True)
        print("[SUCCESS] Installation command finished.")
    except subprocess.CalledProcessError as e:
        print(f"[ERROR] Installation script returned error code: {e}")
        # Don't delete immediately if debugging needed, but generally we should cleanup
        # sys.exit(1)
        
    # 4. Verification
    pwsh_exe = os.path.join(target_dir, "pwsh.exe")
    if os.path.exists(pwsh_exe):
        print(f"\n[VERIFIED] pwsh.exe found at: {pwsh_exe}")
        try:
            # Check version
            ver_cmd = [pwsh_exe, "--version"]
            result = subprocess.run(ver_cmd, capture_output=True, text=True)
            print(f"Version: {result.stdout.strip()}")
        except Exception as e:
            print(f"[WARNING] Could not get version: {e}")
    else:
        print(f"\n[ERROR] pwsh.exe NOT found in target directory. Installation may have failed silently.")
        
    # 5. Cleanup
    if os.path.exists(installer_path):
        os.remove(installer_path)
        print("[INFO] Temporary installer cleaned up.")

if __name__ == "__main__":
    main()
