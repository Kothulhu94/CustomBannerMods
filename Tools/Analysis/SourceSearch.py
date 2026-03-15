import os
import argparse

def search_files(directory, pattern, extensions=['.cs', '.xml']):
    for root, _, files in os.walk(directory):
        for file in files:
            if any(file.endswith(ext) for ext in extensions):
                filepath = os.path.join(root, file)
                try:
                    with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
                        for i, line in enumerate(f):
                            if pattern in line:
                                print(f"{filepath}:{i+1}: {line.strip()}")
                except Exception as e:
                    pass

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Search source files.")
    parser.add_argument("pattern", help="String to search for")
    parser.add_argument("--dir", default=".", help="Directory to search in")
    parser.add_argument("--ext", nargs="+", default=[".cs", ".xml"], help="File extensions")
    args = parser.parse_args()
    search_files(args.dir, args.pattern, args.ext)
