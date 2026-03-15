import os
import re

def clean_file(filepath):
    """
    Cleans a C# file by removing multi-line comments and informal contiguous single-line comments.
    """
    try:
        with open(filepath, 'r', encoding='utf-8') as f:
            content = f.read()

        # 1. Remove block comments /* ... */
        content = re.sub(r'/\*.*?\*/', '', content, flags=re.DOTALL)

        lines = content.split('\n')
        new_lines = []
        i = 0
        while i < len(lines):
            line = lines[i]
            stripped = line.strip()
            
            # 2. Check for contiguous single-line comments (often informal notes)
            if stripped.startswith('//'):
                comment_block = []
                while i < len(lines) and lines[i].strip().startswith('//'):
                    comment_block.append(lines[i])
                    i += 1
                
                # If it's a multi-line contiguous comment, strip it
                if len(comment_block) > 1:
                    continue
                
                # If it's a single line comment, keep it only if it doesn't look like "talking to self"
                # (e.g., informal phrasing, TODOs, or just being extra cautious for production)
                comment_text = comment_block[0].strip()[2:].strip().lower()
                if any(x in comment_text for x in ['todo', 'fixme', 'maybe', 'not sure', 'hack', 'check this']):
                    continue
                
                new_lines.append(comment_block[0])
                continue
            
            new_lines.append(line)
            i += 1

        with open(filepath, 'w', encoding='utf-8') as f:
            f.write('\n'.join(new_lines))
        print(f"Cleaned: {filepath}")

    except Exception as e:
        print(f"Error cleaning {filepath}: {e}")

def walk_and_clean(directory):
    for root, _, files in os.walk(directory):
        for file in files:
            if file.endswith('.cs'):
                clean_file(os.path.join(root, file))

if __name__ == "__main__":
    target_dir = r"d:\Bannerlord_Mods\Modules\LivingWorld\Source"
    walk_and_clean(target_dir)
