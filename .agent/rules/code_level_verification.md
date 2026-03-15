---
trigger: always_on
---

# Rule: Code-Level Verification
- The agent MUST NOT rely on natural language comments within the code to explain functionality.
- For Bannerlord modding, always verify XP(or any) logic by checking:(apply the same rules to all logic searching)
    1. C# classes inheriting from `CampaignBehaviorBase`.
    2. Methods containing `OnDistributeTroopXp`, `AddXp`, or `HeroDeveloper`.
    3. XML files with `<mbeffects>` or custom troop headers.
- If a comment contradicts the code logic, report the discrepancy.
- if reflection fails fall back to scrubbing https://apidoc.bannerlord.com/v/1.3.14/index.html