# Building
### Part 1: Setting up the application in the Discord Developer Portal
<ol>
  <li>Go to <a href="https://discord.com/developers/applications">Discord Developer Portal</a> and create a new application</li>
  <li>Go to <strong>General Information</strong> tab and follow the next fields using that example:
    <ul>
      <li><strong>Name</strong>: 3ds Max <code>{ver}</code> &ndash; <em>where "ver" is a year of your 3ds Max, e.g. 2024.</em></li>
      <li><strong>Description</strong>: Add Discord Rich Presence Features to 3ds Max <code>{ver}</code></li>
    </ul>
  </li>
  <li>Upload a <code>images\XXXX\image_large.png</code> file corresponding to selected years of your 3ds Max version as <strong>App Icon</strong>.</li>
  <li>Go to <strong>OAuth2</strong> tab and add a redirect to <a href="http://127.0.0.1">http://127.0.0.1</a>.</li>
  <li>Go to <strong>Rich Presence</strong> tab and upload <code>image_large.png</code> file <em>(can be found in "images" folder)</em> two times &ndash; as cover image and as asset with <code>image_large</code> name.</li>
</ol>

### Part 2: Editing the sources
<ol>
  <li>Copy <strong>Application ID</strong> from Discord Developer Portal <em>(can be found in "General Information" tab)</em> and add it to <code>AppIDs</code> enumeration in <code>Discord.cs</code> file, following existing syntax.</li>
  <li>Insert your previously added Application ID to <code>Discord.cs</code> file in initialization call, like that:<br /><code>client = new DiscordRpcClient(AppIDs.<strong>MAX_2024</strong>.ToString());</code></li>
  <li>Build it with <strong>"Release"</strong> configuration</li>
</ol>

### Part 3: Building the final release
<ol>
  <li>Create the root folder for your release</li>
  <li>Create a <code>bin\assemblies\</code> sub-folder inside it</li>
  <li>Copy <code>Discord3dsMax.dll</code>, <code>DiscordRPC.dll</code> and <code>Newtonsoft.Json.dll</code> files inside it.</li>
  <li>Create a <code>scripts\startup\</code> sub-folder inside your root.</li>
  <li>Copy <code>Discord3dsMax.ms</code> file without changes inside it.</li>
  <li>Distribute :)</li>
</ol>
