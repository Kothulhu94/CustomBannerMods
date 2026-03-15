
import subprocess
import os
import sys

DECOMPILER = "d:/Bannerlord_Mods/Initialization/bin/ilspy.cmd"
DLL = "d:/Bannerlord_Mods/libs/TaleWorlds.Core.dll"

print(f"Testing decompiler: {DECOMPILER}")
print(f"Target DLL: {DLL}")
sys.stdout.flush()

if not os.path.exists(DECOMPILER):
    print("Decompiler not found!")
    
if not os.path.exists(DLL):
    print("DLL not found!")

cmd = [DECOMPILER, DLL, "-t", "TaleWorlds.Core.Game"]
print(f"Running command: {cmd}")
sys.stdout.flush()

try:
    res = subprocess.run(cmd, capture_output=True, text=True, shell=True)
    print("Return Code:", res.returncode)
    print("STDOUT:", res.stdout[:500])
    print("STDERR:", res.stderr)
except Exception as e:
    print(f"Exception: {e}")

sys.stdout.flush()
