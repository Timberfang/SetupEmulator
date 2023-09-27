# Storage Structure

Currently, SetupEmulator is configured to work with the following folder structure:

- ./Emulation (Base Folder)
	- ./Emulation/bios (BIOS & firmware files, if needed by emulator)
	- ./Emulation/dlc (Game DLC, if any, organized by console and then by game)
	- ./Emulation/emulators (Emulators themselves. Potentially investigate a method to download these from their source at runtime?)
	- ./Emulation/mods (Game mods & textures, organized by console and then by game)
	- ./Emulation/patches (Patches & updates for games, organized by console and then by game)
	- ./Emulation/roms (Games themselves, organized by console)
	- ./Emulation/saves (Save files, organized by console and then by game)
	- ./Emulation/tools (Misc. tools, organized by console)

## Tips

Although not required, it is recommended to pack large, multi-file components, such as multi-file ROMs, DLCs, and HD textures, into zero-compression zip files. This allows for sequential read/write operations, speeding up transfers.