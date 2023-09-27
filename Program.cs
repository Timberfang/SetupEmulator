namespace SetupEmulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Initial plans listed here for emulator setup program, assuming an NAS is used as the remote
            // Folder structure based off of what is used by EmuDeck, and shoudl be compatible with RomM (https://github.com/zurdi15/romm)
            /* Required Folders:
             - ./Emulation (Base Folder)
             - ./Emulation/bios (BIOS & firmware files, if needed by emulator)
             - ./Emulation/dlc (Game DLC, if any, organized by console and then by game)
             - ./Emulation/emulators (Emulators themselves. Potentially investigate a method to download these from their source at runtime?)
             - ./Emulation/mods (Game mods & textures, organized by console and then by game)
             - ./Emulation/patches (Patches & updates for games, organized by console and then by game)
             - ./Emulation/roms (Games themselves, organized by console)
             - ./Emulation/saves (Save files, organized by console and then by game)
             - ./Emulation/tools (Misc. tools, organized by console)
            */

            // Read config.json for emulator configurations

            // Present list of emulators to user, ask to choose which to install

            // Test if needed files exist on remote (emulator & BIOS/firmware files, if applicable)

            // Copy files from remote to ./Emulation

            // List any post-installation steps needed by user (ex: Install firmware in RPCS3, install updates in Citra or Yuzu, etc.)
        }
    }
}