
import json
import collections

INPUT_FILE = "d:/Bannerlord_Mods/API_VERIFICATION_REPORT.json"
OUTPUT_FILE = "d:/Bannerlord_Mods/API_VERIFICATION_REPORT.md"

def main():
    with open(INPUT_FILE, 'r') as f:
        data = json.load(f)
    
    # Sort keys
    sorted_keys = sorted(data.keys())
    
    with open(OUTPUT_FILE, 'w', encoding='utf-8') as f:
        f.write("# API Verification Report\n\n")
        f.write("Validation of scanned APIs against actual Game DLLs using ILSpy.\n")
        f.write("*Note: Signatures are extracted via text search on decompiled source. Inherited members may show as missing if not overridden in the derived class.*\n\n")
        f.write("| API | Status | Verified Signature / Error |\n")
        f.write("|---|---|---|\n")
        
        for key in sorted_keys:
            res = data[key]
            status = res["status"]
            
            icon = "✅" if status == "VERIFIED" else "❌"
            if "MISSING" in status: icon = "⚠️"
            
            # Clean signature for Markdown table
            sig = res["signature"].replace("|", "\\|").replace("\n", " ").strip()
            # Truncate
            if len(sig) > 100:
                sig = sig[:97] + "..."
                
            # Code block
            sig_display = f"`{sig}`"
            
            f.write(f"| `{key}` | {icon} {status} | {sig_display} |\n")

    print(f"Generated {OUTPUT_FILE}")

if __name__ == "__main__":
    main()
