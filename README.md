# Gateway RAM Tools
A collection of useful tools for exploring RAM Dumps created by Gateway 3DS. Written in C# and using .NET 4 for cross-platform GUI friendliness (Windows/Mono/Wine).

![Tools](https://cloud.githubusercontent.com/assets/16966330/16155154/fb01b0e0-34a5-11e6-824a-0402523f0fc6.png)

# Background
This project is created as an eductional piece for myself and the 3DS hacking community to make full use of the RAM Dumping feature in Gateway 3DS.

RAM Dumps are created in batches of Memory Regions which can be viewed by the in-game Gateway menu. The gaps between the Memory Regions are not dumped and so the files cannot be used with convntional RAM exploring software.

# Purpose
The tool will allow you to view the Memory Regions which have been dumped and where within the .bin file these are found. You can also use this tool to expand the .bin file (creating zero padding) in order to fix the offsets.

# Features
* Detect / Validate a Gateway RAM Dump
* View Memory Region offsets and their relative in-file offsets
* Translate In-Game offsets into In-File offsets for use with a hex editor
* Expand a Gateway RAM dump into a full-size RAW dump by zero-padding the missing data
* Batch-expand Gateway RAM Dumps for multiple files
* Export a header segment
* Fixed Address Search: (8/16/32bit Fixed Values)
* Hex Viewer (found inside the Partition Table)
* Pointer Address Search

# Future Development
I'll be looking to integrate further tools into this project, namely around pointer searching / multi layer pointer searching. Any comments / request or ideas are welcome.

# Credits
Thanks to the following people for their input into the project so far
* Gateway 3DS Team
* Maxconsole.com Forums
* msparky76
* makikatze
* storm75x (Fort42)
