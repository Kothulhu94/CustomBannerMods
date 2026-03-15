import sys

def read_in_chunks(file_object, chunk_size=1024):
    while True:
        data = file_object.read(chunk_size)
        if not data:
            break
        yield data

if len(sys.argv) < 2:
    print("Usage: python read_chunks.py <filename>")
    sys.exit(1)

filename = sys.argv[1]
try:
    with open(filename, 'r', encoding='utf-8') as f:
        for chunk in read_in_chunks(f, 4000):
            print(chunk)
            print("--- CHUNK ---")
except Exception as e:
    # Try with utf-16 if utf-8 fails
    try:
        with open(filename, 'r', encoding='utf-16') as f:
            for chunk in read_in_chunks(f, 4000):
                print(chunk)
                print("--- CHUNK ---")
    except Exception as e2:
        print(f"Failed to read file: {e2}")
