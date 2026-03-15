import subprocess
import os
import sys

def run_command(command, ignore_errors=False):
    # Debug print
    # print(f"CMD: {command}")
    try:
        result = subprocess.run(command, shell=True, check=True, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)
        return result.stdout.strip()
    except subprocess.CalledProcessError as e:
        if ignore_errors:
            return ""
        raise e

def main():
    print("Starting batch backup process (Improved)...")
    
    print("Getting file list...")
    # Get status in porcelain mode v1 for consistency
    try:
        status_output = run_command("git status -u --porcelain")
    except subprocess.CalledProcessError as e:
        print("Failed to get git status.")
        print(e.stderr)
        return

    if not status_output:
        print("No changes to commit.")
        return

    files = []
    lines = status_output.split('\n')
    for line in lines:
        if not line.strip():
            continue
        
        # Parse XY PATH
        # XY is 2 chars, then space.
        if len(line) < 4:
            continue
            
        # Check parsing
        raw_path = line[3:] # Taking rest of line including potential spaces in filename?
        # Remove quotes if present (git quotes paths with spaces)
        raw_path = raw_path.strip()
        
        if raw_path.startswith('"') and raw_path.endswith('"'):
            raw_path = raw_path[1:-1]
            
        files.append(raw_path)

    total_files = len(files)
    print(f"Found {total_files} files to process.")

    BATCH_SIZE = 500
    ADD_CHUNK = 50 

    current_batch = []
    batch_count = 0
    
    # We will track successful adds to know if we can commit
    files_staged_count = 0

    for i, file_path in enumerate(files):
        current_batch.append(file_path)
        
        if len(current_batch) >= ADD_CHUNK or i == total_files - 1:
            # Try to add batch
            quoted_paths = [f'"{f}"' for f in current_batch]
            cmd = f'git add {" ".join(quoted_paths)}'
            try:
                run_command(cmd)
                files_staged_count += len(current_batch)
            except subprocess.CalledProcessError as e:
                print(f"Batch add failed. Fallback to individual adds for current chunk.")
                # Fallback
                for f in current_batch:
                    try:
                        run_command(f'git add "{f}"')
                        files_staged_count += 1
                    except subprocess.CalledProcessError as sub_e:
                        print(f"Failed to add file: {f}")
                        print(sub_e.stderr)
            
            current_batch = []

        # Commit logic
        if (i + 1) % BATCH_SIZE == 0 or i == total_files - 1:
            if files_staged_count > 0:
                batch_count += 1
                commit_msg = f"Backup batch {batch_count}: processed up to {i + 1}/{total_files} files"
                print(f"Committing batch {batch_count}...")
                try:
                    run_command(f'git commit -m "{commit_msg}"')
                    # Reset staged count (approximate, since we just committed everything staged)
                    files_staged_count = 0
                except subprocess.CalledProcessError as e:
                    print(f"Commit failed for batch {batch_count}.")
                    print(e.stderr)
                
                if batch_count % 5 == 0:
                    print("Pushing intermediate batches...")
                    run_command("git push", ignore_errors=True)
            else:
                 print(f"Skipping empty commit for batch {batch_count} (nothing staged).")

    print("Final push...")
    run_command("git push", ignore_errors=True)
    print("Done!")

if __name__ == "__main__":
    main()
