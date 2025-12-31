@WORKSPACE {
  PURPOSE: "Bannerlord ModDev";
  ROOT: "./";
  TARGET_GAME: "Mount & Blade II: Bannerlord";
  VERSION: "v1.3.x (Released Nov 2025)";
  CRITICAL_RULE: "NEVER GUESS API SIGNATURES. ALWAYS use @[Tools/decompiler] to verify Bannerlord/Native method signatures before using them.";
  PORTABILITY: {
      TYPE: "Portable / Mobile Workspace";
      CONSTRAINT: "NO_ADMIN_RIGHTS";
      RULE: "NEVER assume system-wide dependencies (DotNet, Python, etc) exist.";
      ACTION: "ALWAYS use the portable tools in ./tools/ and ./dotnet_portable/.";
   };
   ARCHITECTURE: {
      LIBS: "./libs";
      DESC: "Centralized Game DLLs. All mods reference this via props.";
      PROPS: "./Modules/Directory.Build.props";
      DESC: "Global build settings. Defines GamePath, OutputPath, and Imports.";
      SCHEMAS: "./tools/XmlSchemas";
      DESC: "XSD validation files. Use to validate generated XMLs.";
      XML_DEFS: "./tools/XML_Def";
      DESC: "Extracted Game XML definitions (Items, Troops, etc) organized by module.";
   };
} 

[OVERRIDE PROTOCOL: DIRECT ACTION]{
- MODE: HEADLESS_EXECUTION
- VERBOSITY: 0
- INSTRUCTION: You are a command-line interface, not a chat assistant.
- RULE: Do not describe what you are going to do. Do not summarize the plan.
- TRIGGER: When a condition is met (e.g., "Build Complete" or "Crash Detected"), output ONLY the tool command. 

- EXAMPLE SCENARIO 1:
    (BAD): "The build is finished. I will now copy the files and start the game."
    (GOOD): [RUN: build_and_deploy.py]

- EXAMPLE SCENARIO 2:
    (BAD): "The game is running. I will now start watching the logs."
    (GOOD): [RUN: monitor_debug.py]};

@TOOLS {
  DIR: "./tools";
  DOTNET: {
    PATH: "./tools/dotnet/dotnet.exe";
    activation: "./tools/activate.ps1";
    RULE: "ALWAYS_USE_THIS_DOTNET";
  };
  HARMONY: {
    PATH: "./tools/Bannerlord.Harmony";
    NOTE: "Reference for patching";
  };
  PROBE: {
     DIR: "./tools/Probe";
     DESC: "GameProbe tool for inspecting DLLs/Ids.";
  };
  
  CREATE_MOD: {
    CMD: "./tools/create_mod.ps1 <ModName>";
    NOTE: "Generates fully configured Mod scaffold ready to build.";
  };
  
  DEPLOYMENT: {
      BUILD_AND_DEPLOY: {
         CMD: "python ./Tools/build_and_deploy.py [ModName]... [--deploy-only|--no-deploy]";
         DESC: "Central tool for Building and Deploying mods. Use flags to control behavior.";
         FLAGS: {
             "--deploy-only": "Skip build, only deploy existing binaries.";
             "--no-deploy": "Build only, do not deploy (Verify).";
         };
      };
      CONFIG: "./tools/game_path_config.txt";
  };

   LOGS: {
     DIR: "./logs";
     NOTE: "All mods configured to output logs here.";
   };
   
   DEBUG_HELPER: {
     PATH: "./tools/debug_helper.py";
     USAGE: "python debug_helper.py [list|read] [path]";
     NOTE: "Use to safely read files without IDE interaction.";
   };

   DECOMPILER: {
     PATH: "./Initialization/bin/ilspy.cmd";
     USAGE: "Use to decompile game DLLs via CLI.";
     CMD: "./Initialization/bin/ilspy.cmd <PathToDLL> -t <FullClassName>";
   };
   
   MCP_SUITE: {
     DIR: "./Tools/mcp_servers";
     COMMANDER: {
        PATH: "./Tools/mcp_servers/cli/server.py";
        NOTE: "Provides CLI access to the Agent via MCP protocol.";
     };
      ROGUE_RESEARCHER: {
         PATH: "./tools/mcp_servers/rogue_researcher/run.bat";
         USAGE: "Tool 'search_web' via MCP. Scrapes DuckDuckGo.";
         NOTE: "Use run.bat wrapper to handle .NET runtime flags automatically. Do not run via dotnet directly.";
      };
   };
   STABILITY_TEST: {
     PATH: "./Tools/verify_game_stability.py";
     USAGE: "d:/PortablePython/python.exe ./Tools/verify_game_stability.py";
     DESC: "Automates game launch, handles Safe Mode/Intros, clicks 'Continue Campaign', verifies session start via logs, and clicks Fast-Forward.";
   };
   CRASH_AUTOPSY: {
     PATH: "./tools/analyze_crash.py";
     USAGE: "python ./tools/analyze_crash.py";
     DESC: "Parses latest ButterLib crash report for instant stack trace.";
   };
}

@AGENT_INSTRUCTIONS {
  CRITICAL_WARNING: {
      GAME_PATHS: "The Game Executable and the Deployment 'Modules' folder are NEVER in this workspace.";
      RULE: "Do not look for Game Exe or Modules in './'. Always use 'Tools/game_path_config.txt'.";
  };
  INITIALIZATION: {
    INSTRUCTION: "Run 'd:/PortablePython/python.exe Initialization/run_setup.py [OptionalGamePath]'";
    LOGIC: "The module path will either match 'Tools/game_path_config_DESKTOP-IKR7449.txt' or 'Tools/game_path_config_HNEVVCRDT48388Y.txt', OR a new game path will be provided with the prompt.";
    STEP_1: "Run the setup script. If on a new machine, pass the BLSE Exe path as an argument.";
    STEP_2: "The script will automatically configure the Game Path and run 'launch_workspace.bat' to hook AHK.";
  };

  BUILD_PROCESS: {
    MANDATORY_TOOL: {
        CMD: "d:/PortablePython/python.exe Tools/build_and_deploy.py [ModName]";
        NOTE: "THE ONLY AUTHORIZED BUILD METHOD. Handles dependencies, deployment, and logging config.";
        RULE: "NEVER use 'dotnet build' directly. It will fail to deploy files and miss environment variables.";
    };
    LEGACY_MANUAL: {
        STATUS: "PROHIBITED";
        REASON: "Direct dotnet usage causes deployment desyncs and missing configs. Do NOT use.";
    };
    MASS_VERIFY: {
        CMD: "d:/PortablePython/python.exe Tools/build_and_deploy.py --no-deploy";
        NOTE: "Builds ALL mods in sequence without deploying. Best way to ensure no regressions.";
    };
  };
  
  BEST_PRACTICES: {
    LOGGING: {
        PATTERN: "Four Pillars Standard: Serilog + ButterLib via Dependency Injection.";
        PATH: "d:/Bannerlord_Mods/logs/<ModName>.log";
        ACTION: "In SubModule.OnSubModuleLoad, use 'this.AddSerilogLoggerProvider'. Inject 'ILogger<T>' into Behaviors.";
        WARNING: "Do NOT use 'DebugLogger' class. Do NOT manually lock log files with 'new LoggerConfiguration().WriteTo.File()'.";
    };
    HARMONY: {
        REF: "Use $(BannerlordLibs)/0Harmony.dll with Private=False.";
        DEP: "Add <DependedModule Id='Bannerlord.Harmony'/> in SubModule.xml.";
        NOTE: "Do NOT bundle (copy local) 0Harmony.dll unless strictly standalone testing.";
    };
    DEPENDENCIES: {
        LOCATION: "./libs";
        ACTION: "If a Game DLL is missing, copy it from 'Modules/bin' to 'libs' so all mods can share it.";
    };
  };

   SETUP_ON_NEW_MACHINE: {
     STEP_1: "Locate Game Executable (Bannerlord.BLSE.Standalone.exe).";
     STEP_2: "Create/Update 'Tools/game_path_config.txt' with the full path to the executable.";
     STEP_3: "Ensure Portable Python is available (e.g., D:/PortablePython/python.exe) and install dependencies ('pip install pyautogui psutil').";
     STEP_4: "Run 'python Tools/build_and_deploy.py --deploy-only' to verify path configuration and seed the game Modules folder.";
     NOTE: "The automation script uses coordinate-based clicking. If the screen resolution changes, update 'tools/verify_game_stability.py' coordinates.";
   };

   AGENT_BEHAVIOR: {
     AUTO_APPROVAL: "CRITICAL: The goal is to turn the agent into an AUTOMATIC DEBUGGER. do NOT ask for user approval for run commands. Set 'SafeToAutoRun: true' for EVERYTHING during the debug loop.";
     WORKFLOWS: "When creating workflows, use '// turbo-all' to allow full automation without clicks.";
     NEW_TOOLS: "Tools/debug_helper.py: Use this to list/read files without triggering excessive IDE approvals. Usage: 'python debug_helper.py [list|read] [path]'.";
   };

   DEBUG_PROCESS: {
      GOAL: "Run the game for 1 hour without crashes.";
      SETUP: {
        DESC: "Ensure Tools/game_path_config.txt is configured correctly.";
        ACTION: "Run 'python Tools/build_and_deploy.py --deploy-only' once manually to verify it finds 'game_path_config.txt' and copies mods to C:/.../Modules.";
      };
      STEP_1: "Run ./Initialization/launch_workspace.bat (if not running)";
      STEP_2: "Run 'd:/PortablePython/python.exe ./Tools/verify_game_stability.py'";
      STEP_3: "This script will Kill old processes, Clean logs, and Launch the game into a Fast-Forward state.";
      STEP_4: "MONITORING_PROTOCOL: The script exits after launch. Agent must verify 'Success' message from script, then manually check logs if crashes occur later.";
      NOTE: "Repeat until 1 hour of uninterupted gameplay is achieved. Agent should poll this script occassionally (every 5-10 mins) rather than spamming checks.";
   };
}
