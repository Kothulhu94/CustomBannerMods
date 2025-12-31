import os, json, glob

search_paths = [
    os.path.expandvars(r'C:\ProgramData\Mount and Blade II Bannerlord\GameCrashes\*'),
    os.path.expanduser(r'~\Documents\Mount and Blade II Bannerlord\Game Crashes\*')
]

def analyze_latest():
    all_crashes = []
    for path in search_paths: all_crashes.extend(glob.glob(path))
    
    if not all_crashes:
        print(f"NO_CRASH_REPORTS_FOUND. Checked:")
        for p in search_paths: print(f"  - {p}")
        
        # Fallback: Check local logs for exceptions
        print("\nScanning local logs for recent errors...")
        log_dir = r'd:/Bannerlord_Mods/logs'
        if os.path.exists(log_dir):
            for log_file in glob.glob(os.path.join(log_dir, "*.log")):
                try:
                    with open(log_file, 'r', encoding='utf-8') as f:
                        lines = f.readlines()[-50:] # Check last 50 lines
                        for line in lines:
                            if "Exception" in line or "[ERR]" in line:
                                print(f"FOUND ERROR IN {os.path.basename(log_file)}:")
                                print(line.strip())
                except: pass
        return

    latest = max(all_crashes, key=os.path.getctime)
    report = os.path.join(latest, "report.json")
    
    if not os.path.exists(report): return print(f"REPORT_MISSING: {latest}")

    try:
        with open(report, 'r', encoding='utf-8') as f:
            data = json.load(f)
            print("=== CRASH AUTOPSY ===")
            print(f"REPORT: {latest}")
            print(f"MODULE: {data.get('InvolvedModules', [{'Name': 'Unknown'}])[0].get('Name')}")
            print(f"ERROR: {data.get('ExceptionMessage', 'No Message')}")
            print(f"STACK: {data.get('Stacktrace', '')[:500]}...")
            print("=====================")
    except Exception as e: print(f"PARSE_ERROR: {e}")

if __name__ == "__main__": analyze_latest()
