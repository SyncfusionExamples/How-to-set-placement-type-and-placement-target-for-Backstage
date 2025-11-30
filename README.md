# Backstage Placement Type and Placement Target in WPF Ribbon (Syncfusion)

This repository shows how to control where and how the Backstage opens in a WPF Ribbon application using Syncfusion’s WPF Ribbon. It demonstrates both full-screen Backstage and targeted placement relative to any element, so you can deliver a familiar Office-like experience.

## What you will learn
- Configure Backstage to open full screen or near a specific element
- Choose the placement mode that best fits your Ribbon layout
- Target Backstage to open relative to a custom element (e.g., a button or the Ribbon)
- Keep a consistent look-and-feel with Syncfusion themes
- Minimal XAML needed to wire up the behavior

## Repository contents
- Backstage FullScreen Placement Sample/ — shows how to open Backstage in full-screen mode
- Backstage Placement Target Sample/ — shows how to open Backstage relative to a specific element (PlacementTarget)

Open the folders above for ready-to-run examples.

## Getting started
1) Create a new WPF project in Visual Studio.
2) Install the NuGet package that contains Ribbon and Backstage:
   - Syncfusion.Tools.WPF
3) Add the Syncfusion XML namespace in your XAML:
   - xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
4) Add a Ribbon and Backstage to your Window/Page.
5) Configure placement using the Backstage properties described below.

## Backstage placement options
Backstage can appear either as a full-screen surface that covers the app window, or as a panel positioned relative to a specific element. Use these two approaches depending on whether you want an immersive, app-wide experience (full screen) or a contextual surface near a control (placement target).

### Full-screen Backstage
- Goal: Present a complete application surface for file commands and settings
- Typical use: Office-style File view that covers the whole window
- How to set: Assign Backstage’s placement type to full screen

Example (XAML concept):
- Place a Ribbon with a Backstage
- Set the Backstage’s PlacementType to FullScreen
- Bind the Backstage toggle to a Ribbon button (e.g., File)

Key idea: When PlacementType is full screen, Backstage stretches to the window bounds and provides a dedicated experience for navigation, recent files, settings, etc.

### Placement relative to an element (PlacementTarget)
- Goal: Open Backstage near a specific element instead of covering the full window
- Typical use: Show a compact Backstage near the Ribbon or a command button
- How to set: Specify a UI element as the Backstage PlacementTarget

Example (XAML concept):
- Give the target element a Name (x:Name)
- Set Backstage’s PlacementTarget to that element
- Choose an appropriate placement mode so Backstage aligns as intended

Key idea: With a PlacementTarget, Backstage behaves like a positioned surface, letting you keep users focused on the current context.

## Usage tips
- Pick full screen when users expect a complete “File” experience; use target-based placement for lightweight menus.
- Ensure your target element is visible and measured before opening Backstage to avoid unexpected placement.
- Combine with theme settings via syncfusion:SkinStorage.VisualStyle to match Office-like styles.
- If you toggle Backstage programmatically, ensure you first set the desired PlacementType or PlacementTarget before opening.
- Test on different DPIs and window sizes so the Backstage remains accessible and unclipped.

## Running the samples
- Backstage FullScreen Placement Sample/ — open and run to see a Backstage that covers the entire window.
- Backstage Placement Target Sample/ — open and run to see a Backstage positioned relative to a named element.

Both samples are minimal and focused on demonstrating placement setup in XAML, keeping code-behind to the essentials.

## About these samples
These examples provide a quick starting point to configure Syncfusion Backstage in WPF. Adapt the XAML by switching between full-screen and target-based placement to suit your application’s UX. You can further refine appearance and behavior by applying Syncfusion themes, customizing Ribbon items, and wiring commands that match your workflow.

If you need additional properties, behaviors, or edge-case handling, consult the official Syncfusion WPF Ribbon documentation and API reference.
