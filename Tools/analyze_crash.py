import os, json, glob

search_paths = [
    os.path.expandvars(r'C:\ProgramData\Mount and Blade II Bannerlord\GameCrashes\*'),
    os.path.expanduser(r'~\Documents\Mount and Blade II Bannerlord\Game Crashes\*')
]

def analyze_latest():
    all_crashes = []
    for path in search_paths: all_crashes.extend(glob.glob(path))
    
    if not all_crashes: return print("NO_CRASH_REPORTS_FOUND")

    latest = max(all_crashes, key=os.path.getctime)
    report = os.path.join(latest, "report.json")
    
    if not os.path.exists(report): return print(f"REPORT_MISSING: {latest}")

    try:
        with open(report, 'r', encoding='utf-8') as f:
            data = json.load(f)
            print("=== CRASH AUTOPSY ===")
            print(f"MODULE: {data.get('InvolvedModules', [{'Name': 'Unknown'}])[0].get('Name')}")
            print(f"ERROR: {data.get('ExceptionMessage', 'No Message')}")
            print(f"STACK: {data.get('Stacktrace', '')[:500]}...")
            print("=====================")
    except Exception as e: print(f"PARSE_ERROR: {e}")

if __name__ == "__main__": analyze_latest()
