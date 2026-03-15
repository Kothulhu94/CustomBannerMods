import sys

def find_pattern(file_path, pattern):
    with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
        for i, line in enumerate(f):
            if pattern in line:
                print(f"{i+1}: {line.strip()}")

if __name__ == "__main__":
    find_pattern(sys.argv[1], sys.argv[2])
