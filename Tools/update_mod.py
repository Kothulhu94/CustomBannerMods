import os
import sys
import shutil
import subprocess
import argparse
import time

# --- Configuration ---
REPO_URL = "https://github.com/Kothulhu94/CustomBannerMods"
GIT_EXE = "e:/PortableGit/cmd/git.exe"
WORKSPACE_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
MODULES_DIR = os.path.join(WORKSPACE_ROOT, "Modules")
TEMP_DIR_NAME = "_temp_update_sparse"

def run_git_command(args, cwd=None, ignore_error=False):
    """Runs a git command using the portable executable."""
    cmd = [GIT_EXE] + args
    try:
        result = subprocess.run(
            cmd, 
            cwd=cwd, 
            check=True, 
            stdout=subprocess.PIPE, 
            stderr=subprocess.PIPE, 
            text=True
        )
        return result.stdout.strip()
    except subprocess.CalledProcessError as e:
        if not ignore_error:
            print(f"[ERROR] Git command failed: {' '.join(cmd)}")
            print(f"Stdout: {e.stdout}")
            print(f"Stderr: {e.stderr}")
            raise
        return None

def update_mod(mod_name):
    print(f"[*] Starting optimized update for mod: {mod_name}")
    print(f"[*] Repository: {REPO_URL}")
    
    target_mod_path = os.path.join(MODULES_DIR, mod_name)
    temp_repo_path = os.path.join(WORKSPACE_ROOT, TEMP_DIR_NAME)
    
    # 1. Clean up previous temp runs
    if os.path.exists(temp_repo_path):
        print(f"[*] Cleaning up residual temp directory: {temp_repo_path}")
        force_remove_dir(temp_repo_path)
    
    os.makedirs(temp_repo_path)

    try:
        # 2. Initialize Sparse Checkout
        print(f"[*] Initializing sparse checkout...")
        run_git_command(["init"], cwd=temp_repo_path)
        run_git_command(["remote", "add", "-f", "origin", REPO_URL], cwd=temp_repo_path)
        run_git_command(["config", "core.sparseCheckout", "true"], cwd=temp_repo_path)
        
        # 3. Define patterns (Try both root and Modules/ path)
        sparse_file = os.path.join(temp_repo_path, ".git", "info", "sparse-checkout")
        with open(sparse_file, "w") as f:
            f.write(f"{mod_name}/\n")
            f.write(f"Modules/{mod_name}/\n")
        
        # 4. Pull
        print(f"[*] Pulling '{mod_name}' from main branch...")
        run_git_command(["pull", "origin", "main"], cwd=temp_repo_path)
        
        # 5. Locate the mod in the sparse repo
        source_mod_path = None
        
        potential_path_1 = os.path.join(temp_repo_path, mod_name)
        potential_path_2 = os.path.join(temp_repo_path, "Modules", mod_name)
        
        if os.path.isdir(potential_path_1):
            source_mod_path = potential_path_1
            print(f"[*] Found at root: {source_mod_path}")
        elif os.path.isdir(potential_path_2):
            source_mod_path = potential_path_2
            print(f"[*] Found in Modules: {source_mod_path}")
            
        if not source_mod_path:
            print(f"[ERROR] Could not find folder '{mod_name}' in the specific paths.")
            print("Listing downloaded root contents:")
            print(os.listdir(temp_repo_path))
            return False

        # Verify Structure
        print(f"[*] Validating source structure at: {source_mod_path}")
        found_files = []
        for root, dirs, files in os.walk(source_mod_path):
            level = root.replace(source_mod_path, '').count(os.sep)
            indent = ' ' * 4 * (level)
            print(f"{indent}{os.path.basename(root)}/")
            subindent = ' ' * 4 * (level + 1)
            for f in files:
                found_files.append(f)
                if level < 1: # Only print top level files to avoid spam
                     print(f"{subindent}{f}")
        
        has_assets = any(d for d in os.listdir(source_mod_path) if d.lower() in ['assets', 'gui', 'assetpackages'])
        if not has_assets:
            print(f"[WARNING] No Assets/GUI/AssetPackages folder found in '{mod_name}'. This might clearly indicate missing resources!")
        
        # 6. Backup/Remove existing local mod
        if os.path.exists(target_mod_path):
            print(f"[*] Removing existing installed mod at: {target_mod_path}")
            backup_path = target_mod_path + "_BACKUP"
            if os.path.exists(backup_path):
                force_remove_dir(backup_path)
            
            os.rename(target_mod_path, backup_path)
        else:
            print(f"[*] No existing installation found at {target_mod_path}. Creating new.")

        # 7. Move new files into place
        print(f"[*] Installing new version...")
        # Since we are moving from a git repo, we might want to exclude .git directories if any (unlikely inside subfolders but possible)
        # But shutil.move is fine.
        shutil.move(source_mod_path, target_mod_path)
        print(f"[SUCCESS] Installed {mod_name} to {target_mod_path}")

        # 8. Cleanup
        if os.path.exists(target_mod_path + "_BACKUP"):
            print(f"[*] Removing backup...")
            force_remove_dir(target_mod_path + "_BACKUP")
            
        print("[*] Cleaning up temporary entries...")
        force_remove_dir(temp_repo_path)
        
        return True

    except Exception as e:
        print(f"[FATAL ERROR] {e}")
        # Build recovery instructions
        if os.path.exists(target_mod_path + "_BACKUP") and not os.path.exists(target_mod_path):
            print(f"[*] ATTEMPTING RECOVERY: Restoring backup...")
            os.rename(target_mod_path + "_BACKUP", target_mod_path)
        return False

def force_remove_dir(path):
    """ robust directory removal """
    if not os.path.exists(path): return
    
    # Sometimes git files are read-only
    def onerror(func, path, exc_info):
        import stat
        if not os.access(path, os.W_OK):
            os.chmod(path, stat.S_IWUSR)
            func(path)
        else:
            raise
            
    try:
        shutil.rmtree(path, onerror=onerror)
    except Exception as e:
        print(f"[WARN] Failed to fully remove {path}: {e}")


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Update a specific mod from the CustomBannerMods repo.")
    parser.add_argument("mod_name", help="The name of the mod folder to specificially pull and install.")
    args = parser.parse_args()

    success = update_mod(args.mod_name)
    if not success:
        sys.exit(1)
