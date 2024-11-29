# ZoomPanel: A Custom WPF Zoom and Pan Control

Based on Clifford Nelson's [Enhanced WPF Custom Control for Zooming and Panning](https://www.codeproject.com/Articles/1119476/An-Enhanced-WPF-Custom-Control-for-Zooming-and-Pan) and Moravuscz's version of that (https://github.com/Moravuscz/WPFZoomPanel)

Note: codeproject data seems unavailable as of november 2024.

This repo has been upgraded to .NET8 by Menno. Also some refactoring was done and GitVersion was removed.

## Main Changes

By Menno:
- Upgrade to NET8

By Moravuscz:
- Added option for panning the view with mouse wheel up/down
  - Support for horizontal wheel scrolling / mouse wheel tilt
- Fully customizable mouse and keyboard controls
- Refactored and cleaned up code
  - Renamed the namespace & control - for easier differentiation from the original control
  - Fixed some bugs
- XAML namespace definitions and prefix for ease of integration

## Installation & usage

1. Install the package 
2. Add `xmlns:ZoomPanel="https://github.com/CodingConnected/WPF.ZoomPanel"` to your XAML
3. Use `<ZoomPanel:ZoomPanel>` or `</ZoomPanel:ZoomPanelScrollViewer>` for whatever *content* you want to be zoom/pan-able.
4. Add `<ZoomPanel:ZoomPanelViewBox>` to  add an interactive minimap for the ZoomPanel.
