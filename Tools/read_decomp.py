import sys
import os

filename = "decompiled_basicchar.cs"
if not os.path.exists(filename):
    print("File not found")
    sys.exit(1)

try:
    # Try UTF-8 first
    with open(filename, "r", encoding="utf-8") as f:
        content = f.read()
except UnicodeError:
    try:
        # Try UTF-16
        with open(filename, "r", encoding="utf-16") as f:
            content = f.read()
    except Exception as e:
        print(f"Error reading file: {e}")
        sys.exit(1)

# Search for 'List<Equipment>'
    print(content[:5000])
