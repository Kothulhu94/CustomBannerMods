WORKSPACE:
PURPOSE: Bannerlord ModDev
ROOT: ./
TARGET: Mount & Blade II: Bannerlord v1.3.x (Nov 2025)
CRITICAL: NEVER GUESS API SIGNATURES. Verify via @[TOOLS.Decompiler].

CONTEXT[3]{scope, constraint, action}:
PORTABILITY, No Admin/Portable (D: or E:), Use ./tools/ & ./dotnet_portable/ only.
ARCHITECTURE, Centralized Libs/Props, Mods reference ./libs & Directory.Build.props.
DEPENDENCIES, Isolated, Copy missing Game DLLs from Modules/bin to ./libs.

PORTABLE_PYTHON, e/d:/ drive flexible, Path: [DRIVE]:/PortablePython/python.exe.
PS_WARNING, Restricted/Versioned, PS commands may fail. PREFER PYTHON for agents.

PROJECT: LivingWorld
STATUS:LIVING_WORLD, RELEASED/PRIORITY (BUGGY), Submodules[7]: BetterGov, FieldSquire, HappyParty, HonestWork, Landlord, LivingLegend, NewClans. State: @[Modules/LivingWorld/foldersummary.toon].

TOOLS[14]{key, path, cmd, note}:
DOCS, https://apidoc.bannerlord.com/v/1.3.14/index.html, N/A, Primary API reference. MANDATORY for 1.3.x fixes.
DOTNET, ./tools/dotnet/dotnet.exe, N/A, Run ./tools/activate.ps1.
GIT, e/d:/PortableGit/cmd/git.exe, N/A, Portable MinGit.
CREATE_MOD, N/A, ./tools/create_mod.ps1, Scaffolds new mod.
BUILD, N/A, python ./Tools/build_and_deploy.py, MANDATORY. No 'dotnet build'.
STABILITY, N/A, python ./Tools/verify_game_stability.py, Launch/Intro auto.
CRASH, N/A, python ./Tools/analyze_crash.py, Parses ButterLib report.
REFLECTION, N/A, ./Tools/Analysis/ReflectionSearch.ps1, API signature verify.
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

INSTRUCTIONS[6]{topic, rule}:
STARTUP, Run './Initialization/launch_workspace.bat' immediately for AHK hooks.
GAME_EXE, NEVER in ./ workspace. Use 'Tools/game_path_config.txt'.
INIT, Run 'python Initialization/run_setup.py [OptionalBLSEPath]'. Configs path & hooks.
BUILD_ERR, If build tool fails read @[last_build.txt]. Do not read truncated stdout.
LOGGING, SubModule.OnSubModuleLoad -> 'this.AddSerilogLoggerProvider'. No DebugLogger.
TOON_MAINTENANCE, Update @[foldersummary.toon] after IO. Create if missing.

TOON_SPEC:
DESC: Token-Oriented Object Notation. Optimized for LLM Context.
RULES[4]{rule, note}:
NO_SYNTAX, Strip quotes/braces/semicolons. Pure Key-Value.
ARRAYS, Use Header-Based definition [COUNT]{cols}.
STYLE, Telegraphic / Code-Like. No prose.
FLATTEN, Use dot.notation for nested keys.
