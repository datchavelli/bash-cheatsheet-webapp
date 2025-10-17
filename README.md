# Bash Cheatsheet WebApp for Windows

A lightweight Windows desktop application that opens the [Bash Cheatsheet](https://devhints.io/bash) in a standalone window using **WebView2**.  

This app gives you quick access to Bash commands without opening a full browser window.

---

## Features

- Opens `https://devhints.io/bash` in a dedicated window.
- Uses **WebView2** for fast, Chromium-based rendering.
- Customizable icon.
- Can be pinned to the **Start Menu**, **Taskbar**, or accessed via **Flow Launcher**.
- Minimal footprint and portable-friendly.

---

## Requirements

- **Windows 10/11**
- **.NET 7+ Runtime** (if not published as self-contained EXE)
- **Microsoft Edge WebView2 Runtime** (latest Evergreen version recommended)

---

## Installation

1. **Download the EXE** from the release folder or your build output.  
2. (Optional) Place it in a dedicated folder, e.g., `C:\Apps\BashCheatsheet\`.  
3. Create a **shortcut** for Start Menu or pin to Taskbar:
   - Right-click EXE → **Create shortcut**  
   - Move the shortcut to `%APPDATA%\Microsoft\Windows\Start Menu\Programs`  
   - Pin to Start or Taskbar if desired.

---

## Usage

- Launch the app via the EXE, Start Menu, or Flow Launcher.
- The window opens directly to the Bash Cheatsheet.
- Close the app when finished; it does not run in the background.

---

## Customization

- **Change window icon:** Replace the `.ico` file in your project and rebuild the EXE.  
- **Resize window:** Edit `MainForm.cs` dimensions:
  ```csharp
  this.Width = 900;
  this.Height = 700;
