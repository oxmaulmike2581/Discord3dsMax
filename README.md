# Discord3dsMax
Add Discord Rich Presence Features to your version of 3ds Max

## Features
* Shows current scene name in Discord Rich Presence details with real-time updating.
* Shows which time you spent in 3ds Max.
* Shows the correct 3ds Max logo and name for version which you use.

## Supported versions
* 3ds Max 2015
* 3ds Max 2020
* 3ds Max 2023
* 3ds Max 2024

## Notes
* 3ds Max are usually installed in: `C:\Program Files\Autodesk\3ds Max XXXX`, where XXXX - your Max version.<br />If you're installed it in another folder, then you should search it by myself.
* The main difference in each folder is a file `Discord3dsMax.dll`. All other files are identical for all versions.<br />You can install the wrong version of the plugin, e.g. install version for Max 2024 to Max 2015 but then everyone will see that you're using Max 2024 when you're use Max 2015.
* Based on <a href="https://github.com/Lachee/discord-rpc-csharp">discord-rpc-csharp</a> library.

## Installation
* Copy the files from folder which corresponding your 3ds Max version into 3ds Max installation folder with confirmation of merging/replacing.

## Requirements
* <a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework/net452" target="_blank">.NET Framework 4.5.2</a> or newer

## Building
* Visit <a href="BUILDING.md">BUILDING.md</a> for more details.
