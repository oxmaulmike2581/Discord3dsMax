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
<ol>
  <li>Go to <a href="https://discord.com/developers/applications">Discord Developer Portal</a> and create a new application</li>
  <li>Use the following information in the fields:
    <ul>
      <li><strong>Name</strong>: 3ds Max <code>{ver}</code> &ndash; where "ver" is a year of your 3ds Max, e.g. 2024.</li>
      <li><strong>Description</strong>: Add Discord Rich Presence Features to 3ds Max <code>{ver}</code></li>
    </ul>
  </li>
  <li>Copy <strong>Application ID</strong> and add it to <code>AppIDs</code> enumeration in <code>Discord.cs</code> file, following existing syntax.</li>
  <li>Upload a <code>images\XXXX\image_large.png</code> file corresponding to selected years of your 3ds Max version as <strong>App Icon</strong>.</li>
  <li>Go to <strong>Rich Presence</strong> tab and upload <code>images\XXXX\image_large.png</code> file two times &ndash; as cover image and as asset with <code>image_large</code> name.</li>
  <li>Insert your previously added Application ID to <code>Discord.cs</code> file in initialization call, like that:<br /><code>client = new DiscordRpcClient(AppIDs.<strong>MAX_2024</strong>.ToString());</code></li>
  <li>Build it with <strong>"Release"</strong> configuration</li>
</ol>
