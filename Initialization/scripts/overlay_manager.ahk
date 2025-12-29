#SingleInstance Force
SetTitleMatchMode, 2

; Target the process directly for better reliability
TargetWindow := "ahk_exe Antigravity.exe"

; Feedback on startup to confirm script is running
SoundBeep, 750, 500
TrayTip, Antigravity Manager, Script Loaded! Press F8 to toggle modes., 3

ToggleState := 0

F8::
    SoundBeep, 1000, 200 ; Audible feedback on keypress
    ToggleState++
    If (ToggleState > 2)
        ToggleState := 1
    
    If (ToggleState = 1) {
        ; State 1 (Tangible): Restore, Fully Opaque, Interactive
        WinRestore, %TargetWindow%
        WinShow, %TargetWindow%
        WinActivate, %TargetWindow%
        WinSet, Transparent, Off, %TargetWindow% ; Fully Opaque
        WinSet, AlwaysOnTop, On, %TargetWindow%
        WinSet, ExStyle, -0x20, %TargetWindow% ; Interactive (Remove Click-through)
    }
    Else If (ToggleState = 2) {
        ; State 2 (Ghost): Visible, 40% Opacity, Click-Through
        WinShow, %TargetWindow%
        WinSet, Transparent, 102, %TargetWindow% ; 40% of 255
        WinSet, AlwaysOnTop, On, %TargetWindow%
        WinSet, ExStyle, +0x20, %TargetWindow% ; Click-through (Add 0x20)
    }
Return
