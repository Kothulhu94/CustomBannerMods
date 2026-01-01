import sys
import re

def clean_read(file_path, start_marker, max_lines=200):
    with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
        lines = f.readlines()

    start_line = -1
    for i, line in enumerate(lines):
        if start_marker in line and "{" in lines[i+1]: # generic heuristic
             start_line = i
             break
        if start_marker in line: # maybe brace is on same line
             start_line = i
             break
    
    if start_line == -1:
        print(f"Could not find marker: {start_marker}")
        return

    # Brace counting
    brace_count = 0
    in_method = False
    captured_lines = []
    
    lines_read = 0
    for i in range(start_line, len(lines)):
        if lines_read >= max_lines:
            break
            
        line = lines[i]
        
        # Filter comments
        if line.strip().startswith("//"):
            continue
            
        captured_lines.append(line.rstrip())
        lines_read += 1
        
        brace_count += line.count("{")
        brace_count -= line.count("}")
        
        if "{" in line:
            in_method = True
            
        if in_method and brace_count == 0:
            break
            
    print("\n".join(captured_lines))

if __name__ == "__main__":
    if len(sys.argv) < 3:
        print("Usage: python clean_reader.py <file> <method_signature_snippet> [max_lines]")
        sys.exit(1)
    
    limit = 200
    if len(sys.argv) > 3:
        limit = int(sys.argv[3])
        
    clean_read(sys.argv[1], sys.argv[2], limit)
