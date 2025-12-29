import os
import sys

def list_files(directory):
    print(f"Listing files in: {directory}")
    for root, dirs, files in os.walk(directory):
        for file in files:
            print(os.path.join(root, file))

def read_file(filepath):
    print(f"Reading file: {filepath}")
    try:
        with open(filepath, 'r', encoding='utf-8') as f:
            print(f.read())
    except Exception as e:
        print(f"Error reading file: {e}")

if __name__ == "__main__":
    if len(sys.argv) < 3:
        print("Usage: python debug_helper.py [list|read] [path]")
        sys.exit(1)
    
    command = sys.argv[1]
    path = sys.argv[2]
    
    if command == "list":
        list_files(path)
    elif command == "read":
        read_file(path)
    else:
        print(f"Unknown command: {command}")
