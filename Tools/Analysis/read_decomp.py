import sys
import os

if len(sys.argv) < 2:
    print("Usage: read_decomp.py <filename>")
    sys.exit(1)

filename = sys.argv[1]

if not os.path.exists(filename):
    print("File not found")
    sys.exit(1)

def print_members(content):
    lines = content.split('\n')
    for line in lines:
        l = line.strip()
        if "public" in l or "IEnumerable" in l or "List<" in l or "Get" in l:
            print(l)

try:
    with open(filename, "r", encoding="utf-8") as f:
        print_members(f.read())
except UnicodeError:
    try:
        with open(filename, "r", encoding="utf-16") as f:
            print_members(f.read())
    except Exception as e:
        print(f"Error reading file: {e}")
