import sys
import json
import subprocess
import os

def log(msg):
    # Log to stderr to avoid corrupting stdout (JSON-RPC)
    sys.stderr.write(str(msg) + "\n")
    sys.stderr.flush()

def read_message():
    # Basic JSON-RPC message reader
    # In a real generic server, this would handle Content-Length headers if running over HTTP/LanguageServer style
    # But for simple stdio MCP, we often just read lines if it's line-delimited or read json objects.
    # However, MCP usually follows JSON-RPC 2.0.
    # Let's assume one JSON object per line for simplicity in this custom "commander" script.
    try:
        line = sys.stdin.readline()
        if not line:
            return None
        return json.loads(line)
    except json.JSONDecodeError:
        return None

def send_message(msg):
    json.dump(msg, sys.stdout)
    sys.stdout.write("\n")
    sys.stdout.flush()

def handle_request(request):
    req_id = request.get("id")
    method = request.get("method")
    params = request.get("params", {})

    log(f"Received: {method}")

    if method == "initialize":
        return {
            "jsonrpc": "2.0",
            "id": req_id,
            "result": {
                "protocolVersion": "2024-11-05",
                "capabilities": {
                    "tools": {}
                },
                "serverInfo": {
                    "name": "Commander CLI",
                    "version": "1.0.0"
                }
            }
        }
    
    if method == "notifications/initialized":
        # No response needed for notifications
        return None

    if method == "tools/list":
        return {
            "jsonrpc": "2.0",
            "id": req_id,
            "result": {
                "tools": [
                    {
                        "name": "run_command",
                        "description": "Execute a shell command on the host machine.",
                        "inputSchema": {
                            "type": "object",
                            "properties": {
                                "command": {
                                    "type": "string",
                                    "description": "The command line to execute."
                                },
                                "cwd": {
                                    "type": "string",
                                    "description": "Current working directory (optional)."
                                }
                            },
                            "required": ["command"]
                        }
                    }
                ]
            }
        }

    if method == "tools/call":
        tool_name = params.get("name")
        args = params.get("arguments", {})
        
        if tool_name == "run_command":
            cmd = args.get("command")
            cwd = args.get("cwd", os.getcwd())
            
            log(f"Executing: {cmd} in {cwd}")
            
            try:
                # Run the command
                result = subprocess.run(
                    cmd, 
                    shell=True, 
                    cwd=cwd, 
                    capture_output=True, 
                    text=True
                )
                
                output = result.stdout
                if result.stderr:
                    output += "\nErrors:\n" + result.stderr

                return {
                    "jsonrpc": "2.0",
                    "id": req_id,
                    "result": {
                        "content": [
                            {
                                "type": "text",
                                "text": output
                            }
                        ]
                    }
                }
            except Exception as e:
                return {
                    "jsonrpc": "2.0",
                    "id": req_id,
                    "error": {
                        "code": -32603,
                        "message": str(e)
                    }
                }

    # Default not found
    return {
        "jsonrpc": "2.0",
        "id": req_id,
        "error": {
            "code": -32601,
            "message": "Method not found"
        }
    }

def main():
    log("Commander CLI MCP Server Started")
    while True:
        try:
            req = read_message()
            if req is None:
                break
            
            resp = handle_request(req)
            if resp:
                send_message(resp)
        except Exception as e:
            log(f"Error: {e}")

if __name__ == "__main__":
    main()
