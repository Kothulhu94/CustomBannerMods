import sys

def extract_lines(file_path, start_line, end_line):
    start = int(start_line)
    end = int(end_line)
    
    with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
        lines = f.readlines()
        
    for i in range(start - 1, min(end, len(lines))):
        line = lines[i]
        # Clean IL comments on the fly for better density
        if line.strip().startswith("//"):
            continue
        print(f"{i+1}: {line.rstrip()}")

if __name__ == "__main__":
    extract_lines(sys.argv[1], sys.argv[2], sys.argv[3])
