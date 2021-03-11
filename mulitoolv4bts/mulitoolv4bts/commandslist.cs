using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace slinkosmtv4
{
    class commandslist
    {
        // DON'T MIND THE MESS HERE. What matters is that it works ;)
        public void printCMDS() // prints commands
        {
            Console.WriteLine("bcolor (color: black, blue, cyan, darkblue, darkcyan, darkgray, darkgreen, darkmagenta, darkred, darkyellow, gray, green, magenta, red, white, yellow) - changes terminal background color\n"
                                +"browser - opens web browser\n"
                                +"calc - opens four function resuming calculator\n"
                                + "cb - opens censorbar config\n"
                                +"cd,(filepath) - navigate to a different directory on your computer\n"
                                +"cdhelp - provides examples on how to use the cd command\n"
                                +"clear - clears terminal window\n"
                                +"clipboard - opens clipboard history\n"
                                +"close - closes terminal\n"
                                +"copydir,(directory path to copy),(destination path) - copys a directory (including files and directories within the directory) to another path\n"
                                +"copyfile,(file path to copy),(destination path) - copys a file to another path\n"
                                +"credits - Opens SlinkOS credits\n"
                                + "dataconversion - Opens up the data conversion tool\n"
                                +"del,(filepath) - deletes file at specified path\n"
                                +"disablestartup (on or off) - Disables or enables startup terminal\n"
                                +"equationcalc - opens equation calculator\n"
                                +"fcolor (color: black, blue, cyan, darkblue, darkcyan, darkgray, darkgreen, darkmagenta, darkred, darkyellow, gray, green, magenta, red, white, yellow) - changes terminal font color\n"
                                +"fileiohelp - outputs basic formatting examples for IO related commands\n"
                                +"hibernate - hibernates computer\n"
                                +"help - lists all available commands\n"
                                +"killid (process ID) - kills process with given ID\n"
                                + "killname (process name) - kills process with given process name (will kill every process with given name)\n"
                                +"listcolors - lists all colors for fcolor and bcolor command\n"
                                +"listprocesses - lists all running processes with their IDs and names\n"
                                +"ls,(filepath) - lists all directories and files at specified path\n"
                                + "movedir,(directory path to move),(destination path) - moves a directory (including files and directories within the directory) to another path\n"
                                + "movefile,(file path to move),(destination path) - move a file to another path\n"
                                +"newcalc - opens the new four function calculator\n"
                                + "openpaint (on or off) - sets settings to open paint after screenshot from main menu is taken\n"
                                +"perfomance - opens CPU perfomance info window\n"
                                +"postnote - opens new postnote\n"
                                +"restart - restarts computer\n"
                                +"restartslinkos - restarts SlinkOS\n"
                                +"rm,(directorypath) - deletes directory with contained files at specified path\n"
                                +"setuname (username) - sets username settings to desired username\n"
                                +"sleep - puts computer in sleep state\n"
                                +"shutdown - shuts down your computer (NOTE: DOES NOT DEFAULT HIBERNATE LIKE WINDOWS 10 DOES FROM START MENU)\n"
                                +"screenshot - opens screenshot tool\n"
                                +"settings - opens settings\n"
                                +"spammer - opens text spammer\n"
                                +"stopwatch - opens stopwatch\n"
                                +"sysinfo - prints system information report\n"
                                +"terminate - kill SlinkOS\n"
                                +"timer - opens timer\n"
                                +"takescreenshot\n"
                                +"uninstall - uninstalls SlinkOS from registry\n"
                                +"versioncheck (on or off) - sets version check setting to check for an update for SlinkOS via Slink Soft\n");
        }
    }
}
