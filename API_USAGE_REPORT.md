# Player Settlement Runtime Placement API Analysis

## 1. Overview
The Player Settlement mod uses a custom `CampaignBehavior` called `PlayerSettlementBehaviour` to manage the runtime placement of settlements. It bypasses the standard game editor by dynamically generating XML definitions and injecting them into the `MBObjectManager` at runtime.

## 2. API Workflow (In Order)

### Phase 1: Initiation
The placement process is triggered by setting the `SettlementRequest` property in `PlayerSettlementBehaviour`.

*   **API**: `public SettlementType SettlementRequest { get; set; }`
*   **Location**: `PlayerSettlementBehaviour.cs` (Line ~345)
*   **Usage**: UI ViewModels (e.g., `PlayerSettlementBuildVM`) set this property to `SettlementType.Town`, `Castle`, or `Village`.
*   **Effect**: The `Tick` loop detects this request and calls the appropriate build method (e.g., `BuildTown()`).

### Phase 2: Configuration & Selection
The mod prompts the user for configuration (Name, Culture) before entering the visual placement mode.

*   **API**: `private void BuildTown()`
*   **Location**: `PlayerSettlementBehaviour.cs` (Line ~4401)
*   **Logic**:
    1.  Sets `PlacementSupported = false`.
    2.  Opens a Text Inquiry for the settlement name.
    3.  Opens a Multi-Selection Inquiry for the culture (if not forced to player culture).
    4.  Calls `Apply(name, culture)` to prepare templates.

### Phase 3: Visual Placement (The "Ghost")
This is the core runtime loop where the player positions the settlement.

*   **API**: `private void StartSettlementPlacement()`
*   **Location**: `PlayerSettlementBehaviour.cs` (Line ~4639)
*   **Logic**:
    *   Initializes `settlementVisualEntity` using the prefab `player_settlement_ghost`.
    *   activates the "Ghost" entity.
    *   Displays placement help hints.

*   **API**: `UpdateSettlementVisualEntity(ref InputInformation)` (Inferred)
*   **Location**: `PlayerSettlementBehaviour.cs` (Line ~1259 - inferred)
*   **Logic**:
    *   **Input Handling**: Reads `InputInformation` for mouse/keyboard states.
    *   **Transformation**: Updates `settlementPlacementFrame` (MatrixFrame) based on input (Rotation, Scale).
    *   **Visual Update**: Calls `gameEntity.SetGlobalFrame(ref frame)` to move the ghost.
    *   **Deep Edit**: Allows manipulating sub-entities (children) independently.

### Phase 4: Finalization & Injection
When the player confirms placement, the mod constructs the final settlement object.

*   **API**: `private void ApplyPlaced(string name, CultureObject culture, string? villageType)`
*   **Location**: `PlayerSettlementBehaviour.cs` (Line ~2799)
*   **Logic**:
    1.  **Template Retrieval**: Loads the XML template for the selected culture/type.
    2.  **Coordinate Injection**: Replaces placeholders `{{G_POS_X}}` and `{{G_POS_Y}}` in the XML with the final `settlementPlacementFrame` coordinates.
    3.  **XML Wrap**: Wraps the node in `<Settlements>...</Settlements>`.
    4.  **Object Registration**:
        *   Calls `MBObjectManager.Instance.LoadXml(xmlDocument)` to parse the new definition.
        *   Calls `MBObjectManager.Instance.GetObject<Settlement>(stringId)` to instantiate the actual game object.
    5.  **State Setup**:
        *   Sets name via `settlement.SetName()`.
        *   Sets visibility `settlement.IsVisible = true`.
        *   Applies costs via `GiveGoldAction`.

## 3. Assets Used

*   **Prefabs**:
    *   `player_settlement_ghost`: The visual representation during placement.
    *   `player_settlement_ghost_gate`: Visual for gate placement.
*   **XML Templates**:
    *   Located in `ModuleData/Player_Settlement_Templates/`.
    *   Parsed using `System.Xml.XmlDocument`.
*   **Game Authorities**:
    *   `MBObjectManager`: The central registry for all game entities. Used to inject the new settlement.
    *   `Campaign`: Used to track time and trigger events.

## 4. Code Deep Dive (Zero-Look Summary)
*   **Dynamic XML Injection**: The mod practically "hacks" the game's loading system by feeding it raw XML strings generated at runtime. It manually constructs a valid `Settlement` XML node with the player's chosen coordinates and forces the ObjectManager to load it as if it were a file.
*   **Input Handling**: It does not use standard mission input handlers. Instead, it seems to hook into a global input update or MapScreen update to modify the `MatrixFrame` of the visual entity directly.
*   **Deep Edit System**: A custom implementation that allows selecting individual children of the visual entity and applying local transforms (Rotation/Scale) which are then saved into the `OverwriteSettlementItem` data structure for persistence.
