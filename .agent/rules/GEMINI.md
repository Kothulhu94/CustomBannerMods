WORKSPACE:
PURPOSE: Bannerlord ModDev
ROOT: ./
TARGET: Mount & Blade II: Bannerlord v1.3.x (Nov 2025)
CRITICAL: NEVER GUESS API SIGNATURES. Follow API_DISCOVERY_PROTOCOL. Prefer TaleWorlds namespaces.

CONTEXT[3]{scope, constraint, action}:
PORTABILITY, No Admin/Portable (D: or E:), Use ./tools/ & ./dotnet_portable/ only.
ARCHITECTURE, Centralized Libs/Props, Mods reference ./libs & Directory.Build.props.
DEPENDENCIES, Isolated, Copy missing Game DLLs from Modules/bin to ./libs.

PROJECT: LivingWorld
STATUS:LIVING_WORLD, RELEASED/PRIORITY (BUGGY), Submodules[7]: BetterGov, FieldSquire, HappyParty, HonestWork, Landlord, LivingLegend, NewClans. State: @[Modules/LivingWorld/foldersummary.toon].

TOOLS[16]{key, path, cmd, note}:
VECTOR_DB, ./Bannerlord_Vector_DB, N/A, Local semantic index for API discovery.
METADATA, ./Bannerlord_API_1.3.14_Metadata.json, N/A, Official API registry (v1.3.14). Use for namespace/version validation.
RAG_CHUNKS, ./RAG_Chunks, N/A, Detailed class/member definitions. Primary source for exact method signatures.
DOTNET, ./tools/dotnet/dotnet.exe, N/A, Run ./tools/activate.ps1.
GIT, e/d:/PortableGit/cmd/git.exe, N/A, Portable MinGit.
CREATE_MOD, N/A, ./tools/create_mod.ps1, Scaffolds new mod.
BUILD, N/A, python ./Tools/build_and_deploy.py, MANDATORY. No 'dotnet build'.
STABILITY, N/A, python ./Tools/verify_game_stability.py, Launch/Intro auto.
CRASH, N/A, python ./Tools/analyze_crash.py, Parses ButterLib report.
NAMESPACES, TaleWorlds.*, N/A, Preferred namespace for all logic.
SEARCH, N/A, python ./Tools/Analysis/SourceSearch.py, Multiline source search.
CLEANUP, N/A, ./Tools/CleanupWorkspace.ps1, Root/Temp purge.
PYTHON, e/d:/PortablePython/python.exe, N/A, Portable Runtime.
GAME_PATH, ./tools/game_path_config.txt, N/A, Game EXE location.
LOGS, ./logs, N/A, Serilog/Crash output.
PWSH, ./Tools/pwsh/pwsh.exe, N/A, Portable PowerShell 7 (Core).

PROTOCOL_OVERRIDE:
MODE: HEADLESS_EXECUTION (Verbosity 0)
TRIGGER: Output ONLY tool command when condition met. No descriptions.
EXAMPLES[2]{input, output}:
"Build finished. I'll copy files.", [RUN: build_and_deploy.py]
"Game running. Watching logs.", [RUN: monitor_debug.py]

API_DISCOVERY_PROTOCOL[3]{step, tool, goal}:
DISCOVERY, VECTOR_DB/RAG_CHUNKS, Semantic/Grep keyword discovery.
VALIDATION, METADATA, Namespace/Version v1.3.14 verification.
RETRIEVAL, RAG_CHUNKS, Method signature/member retrieval.

INSTRUCTIONS[7]{topic, rule}:
STARTUP, Run './Initialization/launch_workspace.bat' immediately for AHK hooks.
GAME_EXE, NEVER in ./ workspace. Use 'Tools/game_path_config.txt'.
INIT, Run 'python Initialization/run_setup.py [OptionalBLSEPath]'. Configs path & hooks.
BUILD_ERR, If build tool fails read @[last_build.txt]. Do not read truncated stdout.
LOGGING, SubModule.OnSubModuleLoad -> 'this.AddSerilogLoggerProvider'. No DebugLogger.
TOON_MAINTENANCE, Update @[foldersummary.toon] after IO. Create if missing.
API_DISCOVERY, Follow API_DISCOVERY_PROTOCOL. NEVER skip to implementation without verifying signatures. Prefer 'TaleWorlds.*' over 'SandBox.*'.

TOON_SPEC:
DESC: Token-Oriented Object Notation. Optimized for LLM Context.
RULES[4]{rule, note}:
NO_SYNTAX, Strip quotes/braces/semicolons. Pure Key-Value.
ARRAYS, Use Header-Based definition [COUNT]{cols}.
STYLE, Telegraphic / Code-Like. No prose.
FLATTEN, Use dot.notation for nested keys.
