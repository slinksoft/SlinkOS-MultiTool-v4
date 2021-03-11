using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace slinkosmtv4
{
    class StartupConsole
    {
        //terminal code
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);



        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        const uint MF_BYCOMMAND = 0x00000000;
        const uint MF_GRAYED = 0x00000001;
        const uint SC_CLOSE = 0xF060;
        const uint MF_DISABLED = 0x00000002;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32.dll", SetLastError = true)]
        static extern uint EnableMenuItem(IntPtr hMenu, uint itemId, uint uEnable);

        bool terminalhandle;
        int version, revision, build;
        string completevnumber;
        string uname;
        bool paintopen, ifversioncheck, ifStartup;
        string cmd;

        public static void main(String[] args)
        {
            new StartupConsole();
        }

        public StartupConsole()
        {
            Console.Title = "SlinkOS - Terminal";
            IntPtr h = FindWindow(null, "SlinkOS - Terminal");

            // detect slinkos installed and reads setting to skip startup terminal
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\")) // finds if registry keys exists already so it will not overwrite incorrect value.
            {
                string findkey = (string)Key.GetValue("SlinkOS");
                if (findkey != null)
                {

                    StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                    uname = read.ReadLine();
                    paintopen = Convert.ToBoolean(read.ReadLine());
                    ifversioncheck = Convert.ToBoolean(read.ReadLine());
                    ifStartup = Convert.ToBoolean(read.ReadLine());
                    read.Close();
                    
                    if (ifStartup == true)
                    {
                        ShowWindow(h, 0);
                        terminalhandle = false;
                        //CloseInitialConsoleWindow close = new CloseInitialConsoleWindow();
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        SplashScreen s = new SplashScreen();
                        s.ShowDialog();
                    }
                }
            }

                    //set version number.
                    version = 4;
            revision = 90;
            build = 20;
            Console.Title = "SlinkOS - Terminal";
            completevnumber = Convert.ToString(version) + "." + Convert.ToString(revision) + "-" + Convert.ToString(build);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("SlinkOS Version: " + completevnumber);
            Console.WriteLine("For help, use the \"help\" command. If you are finishing the uninstallation of SlinkOS, "
                + "use the \"cleanup\" command.");
            Console.WriteLine("-------------------------------------------------------------------");
            terminalhandle = true;
            while (terminalhandle == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(System.Environment.UserName + "@SlinkOS:~# ");
                Console.ForegroundColor = ConsoleColor.Gray;
                cmd = Console.ReadLine();

                if (cmd == "help")
                {
                    Console.WriteLine("cleanup - cleanup previous SlinkOS installation\nclear - clear terminal window\nstartx - Starts SlinkOS\nterminate - Close SlinkOS startup "
                        + "terminal(don't run SlinkOS)");
                }
                else if (cmd == "clear")
                {
                    Console.Clear();
                }
                else if (cmd == "terminate")
                {
                    System.Environment.Exit(0);
                }
                else if (cmd == "startx")
                {
                    ShowWindow(h, 0);
                    terminalhandle = false;
                    //CloseInitialConsoleWindow close = new CloseInitialConsoleWindow();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    SplashScreen s = new SplashScreen();
                    s.ShowDialog();
                }
                else if (cmd == "cleanup")
                {
                    using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\")) // finds if registry keys exists already so it will not overwrite incorrect value.
                    {
                        string findkey = (string)Key.GetValue("SlinkOS");
                        if (findkey == null)
                        {
                            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS") == true)
                            {
                                Console.WriteLine("Detected SlinkOS directory. Cleaning up...");
                                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS", true);
                                Console.WriteLine("SlinkOS installation cleaned up.");
                            }
                            else
                                Console.WriteLine("SlinkOS directory not detected! SlinkOS is not installed on your system.");
                        }
                        else
                        {
                            Console.WriteLine("It looks like you haven't started uninstalling SlinkOS from the SlinkOS GUI or" +
                                " SlinkOS terminal. Please start the uninstallation process from the \"Settings\" window from the" +
                                " SlinkOS menu, or use the SlinkOS terminal and use the command \"uninstall\".");
                        }
                    }
                }
                else
                    Console.WriteLine(cmd + " is not a supported command."
                   + "Please use \"help\" for a list of available startup commands.");
            }
        }
    }
}
