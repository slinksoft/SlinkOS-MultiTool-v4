using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Drawing;
using snake;
using System.Collections;

namespace slinkosmtv4
{
    class terminal
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

        //settings vars
        string uname;
        bool paintopen, ifversioncheck, ifStartup;
        int version, revision, build;
        string completevnumber;
        bool ticked; // var used for fix for default console color, so fg color is not changed everytime opened in case the user wants to change colors (theme) for the current running session of slinkos.

        private string getExternalIp()
        {
            try
            {
                string externalIP;
                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
                return externalIP;
            }
            catch { return null; }
        }

        public void loadSettings()
        {
            StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
            uname = read.ReadLine();
            paintopen = Convert.ToBoolean(read.ReadLine());
            ifversioncheck = Convert.ToBoolean(read.ReadLine());
            ifStartup = Convert.ToBoolean(read.ReadLine());
            read.Close();
            //set version number.
            version = 4;
            revision = 90;
            build = 20;
            completevnumber = Convert.ToString(version) + "." + Convert.ToString(revision) + "-" + Convert.ToString(build);

        }

        public void executeTerminal()
        {
            loadSettings();
            // starts up console and closes it to ensure no bugs to closing console occurs in future use.
            AllocConsole();
            Console.Title = "SlinkOS - Terminal";
            IntPtr h = FindWindow(null, "SlinkOS - Terminal");
            ShowWindow(h, 0);
            AllocConsole(); //create instance of console
            Console.Title = "SlinkOS - Terminal";
            ShowWindow(h, 1); //show console
            Console.Clear();
            if (ticked == false) // fix for default console color, so fg color is not changed everytime opened in case the user wants to change colors (theme) for the current running session of slinkos.
            {
                ticked = true;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            terminalhandle = true;

            //handles disable closing of window to prevent close of slinkos
            IntPtr hwnd = GetConsoleWindow();
            IntPtr hmenu = GetSystemMenu(hwnd, false);
            uint hWindow = EnableMenuItem(hmenu, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED | MF_GRAYED);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("SlinkOS Version: " + completevnumber);
            Console.WriteLine("WARNING: All GUI will be unstable when SlinkOS terminal is running." + System.Environment.NewLine + "To Resume GUI, close the terminal by using command \"close\"");
            Console.WriteLine("WARNING: Closing the SlinkOS Terminal through the taskbar will" + System.Environment.NewLine + "terminate SlinkOS.");
            Console.WriteLine("WARNING: SOME COMMANDS ARE FOR ADVANCED USERS ONLY! SlinkSoft" + System.Environment.NewLine + "is not responsible for any data loss due to misuse of some commands.");
            Console.WriteLine("-------------------------------------------------------------------");

            string defPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            #region SlinkOS terminal commands
            while (terminalhandle == true)
            {
                Console.Write(uname + "@SlinkOS:" + defPath + " ~#");
                string cmd = Console.ReadLine();

                switch(cmd)
                {
                    case "close":
                        {
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "terminate":
                        {
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            Environment.Exit(0);
                            break;
                        }
                    case "binary":
                        {
                            Console.WriteLine("The ASCII to Binary converter has been upgraded and renamed to the "
                       + "\"Data Type Conversion\" tool. Try using \"dataconversion\" to open up the tool.");
                            break;
                        }
                    case "dataconversion":
                        {
                            dataConversion openme = new dataConversion();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "hex":
                        {
                            Console.WriteLine("The ASCII to Hex converter has been merged into the binary tools icon, which "
                       + "is now named the \"Data Type Conversion\" tool. Try using \"dataconversion\" to open up the tool.");
                            break;
                        }
                    case "calc":
                        {
                            calculator openme = new calculator();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "timer":
                        {
                            timer openme = new timer();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "stopwatch":
                        {
                            stopwatch openme = new stopwatch();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "cb":
                        {
                            censorbar openme = new censorbar();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "browser":
                        {
                            browser openme = new browser();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "spammer":
                        {
                            spammer openme = new spammer();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "screenshot":
                        {
                            screenshot openme = new screenshot();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "settings":
                        {
                            settings openme = new settings();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "clipboard":
                        {
                            foreach (Form c in Application.OpenForms)
                            {
                                if (c is clipboardcs)
                                {
                                    c.Show();
                                }
                            }
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    case "sysinfo":
                        {
                            string localip = "";
                            string time = DateTime.Now.ToString("hh:mm:ss tt");
                            string date = DateTime.Today.ToString("M-dd-yyyy @ ");
                            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                            {
                                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                                {
                                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                                    {
                                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                        {
                                            localip += "- " + ni.Name + ": " + ip.Address.ToString() + System.Environment.NewLine;
                                        }
                                    }
                                }
                            }

                            Console.WriteLine("Report Printed On: " + date + time + System.Environment.NewLine + "----------------------------------------------------------" + System.Environment.NewLine + "External IP: " + getExternalIp() + System.Environment.NewLine + "Local IP: " + System.Environment.NewLine + localip + System.Environment.NewLine + "OS Name: " + System.Environment.OSVersion + System.Environment.NewLine + "Version: " + System.Environment.Version + System.Environment.NewLine + "Username: " + System.Environment.UserName + System.Environment.NewLine + "Domain Name: " + System.Environment.UserDomainName + System.Environment.NewLine + "Machine Name: " + System.Environment.MachineName + System.Environment.NewLine + "Is 64 bit: " + System.Environment.Is64BitOperatingSystem + System.Environment.NewLine + "# Of Processors: " + System.Environment.ProcessorCount + System.Environment.NewLine + "SlinkOS Version: " + completevnumber);
                        break;
                        }
                    case "hibernate":
                        {
                            Application.SetSuspendState(PowerState.Hibernate, true, true);
                            break;
                        }
                    case "sleep":
                        {
                            Application.SetSuspendState(PowerState.Suspend, true, true);
                            break;
                        }
                    case "restart":
                        {
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            Process.Start("shutdown.exe", "-r -t 0");
                            break;
                        }
                    case "shutdown":
                        {
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            Process.Start("shutdown.exe", "-s -t 0");
                            break;
                        }
                    case "uninstall":
                        {
                            RegistryKey del = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                            del.DeleteValue("SlinkOS");
                            Console.WriteLine("Terminating SlinkOS...");
                            MessageBox.Show("Uninstalled. Please restart MultiTool v4/SlinkOS (the portable/downloaded executable that you initially downloaded) " +
                                "for the uninstallation/cleanup to complete.", "SlinkOS Uninstalled");
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            Environment.Exit(0);
                            break;
                        }
                    case "restartslinkos":
                        {
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\slinkosmtv4.exe");
                            Application.Exit();
                            break;
                        }
                    case "listprocesses":
                        {
                            Process[] getlist = Process.GetProcesses();
                            ArrayList generatelist = new ArrayList();
                            foreach (Process executefetch in getlist)
                            {
                                generatelist.Add("Name: " + executefetch.ProcessName + " | " + "ID: " + executefetch.Id);
                            }
                            generatelist.Sort();
                            for (int i = 0; i < generatelist.Count; i++)
                            {
                                Console.WriteLine(generatelist[i]);
                            }
                                    break;
                        }
                    case "listcolors":
                        {
                            Console.WriteLine("black, blue, cyan, darkblue, darkcyan, darkgray, darkgreen, darkmagenta, darkred, darkyellow, gray, green, magenta, red, white, yellow");

                            break;
                        }
                    case "snake":
                        {
                            gameCanvas openSnake = new gameCanvas();
                            openSnake.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "zelda":
                        {
                            slinkosmtv4.zelda.game openZelda = new slinkosmtv4.zelda.game();
                            openZelda.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "performance":
                        {
                            performance openme = new performance();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "credits":
                        {
                            slinkoscredits openme = new slinkoscredits();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "newcalc":
                        {
                            newcalc openme = new newcalc();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "equationcalc":
                        {
                            equationCalc openme = new equationCalc();
                            openme.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "postnote":
                        {
                            Random rand = new Random();
                            postnote newPost = new postnote(rand.Next(100, 200));
                            newPost.Show();
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "votd":
                        {
                            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\pkge.exe");
                            ShowWindow(h, 0);
                            terminalhandle = false;
                            break;
                        }
                    case "help":
                        {
                            commandslist list = new commandslist();
                            list.printCMDS();
                            break;
                        }
                    case "fileiohelp":
                        {
                            Console.WriteLine("For files - Example: copyfile,C:\\Users\\Dan\\Desktop\\1\\textfile.txt,C:\\Users\\Dan\\Desktop\\2\\\nor\n" +
                                "Example: copyfile,textfile.txt,Folder_1\\ \n" +
                                "Same is applied to other file commands except for simple cd paths. Please use specified path when moving or copying directories.\n" +
                                "For directories - Example: copydir,C:\\Users\\Dan\\Desktop\\1\\,C:\\Users\\Dan\\Desktop\\2\\\n" +
                                "Same is applied to other directory commands.");
                            break;
                        }
                    default:
                        {
                            if (cmd.Contains("versioncheck") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                if (a == "on")
                                {
                                    ifversioncheck = true;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Version Check set to: On. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                                else if (a == "off")
                                {
                                    ifversioncheck = false;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Version Check set to: Off. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                            }
                            else if (cmd.Contains("disablestartup") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                if (a == "on")
                                {
                                    ifStartup = true;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Disable Startup Terminal set to: On. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                                else if (a == "off")
                                {
                                    ifStartup = false;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Disable Startup Terminal set to: Off. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                            }
                            else if (cmd.Contains("openpaint") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                if (a == "on")
                                {
                                    paintopen = true;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Open Paint On Screenshot set to: On. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                                else if (a == "off")
                                {
                                    paintopen = false;
                                    StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                    write.WriteLine(uname);
                                    write.WriteLine(paintopen);
                                    write.WriteLine(ifversioncheck);
                                    write.WriteLine(ifStartup);
                                    write.Close();
                                    Console.WriteLine("Open Paint On Screenshot set to: Off. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                                }
                            }

                            else if (cmd.Contains("setuname") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                uname = a;
                                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                                write.WriteLine(uname);
                                write.WriteLine(paintopen);
                                write.WriteLine(ifversioncheck);
                                write.WriteLine(ifStartup);
                                write.Close();
                                Console.WriteLine("Username changed. Please restart SlinkOS to take affect (use command \"restartslinkos\")");
                            }
                            else if (cmd.Contains("killid") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                int ID = Convert.ToInt32(a);
                                try
                                {
                                    Process p = Process.GetProcessById(ID);
                                    p.Kill();
                                }
                                catch (System.ArgumentException e)
                                {
                                    Console.WriteLine("Process ID " + ID + " does not exist!");
                                }
                            }
                            else if (cmd.Contains("killname") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];
                                string name = Convert.ToString(a);
                                Process[] p = Process.GetProcessesByName(name);
                                foreach (Process proc in p)
                                    proc.Kill();
                            }

                            else if (cmd.Contains("ls") && cmd.Contains(","))
                            {
                                string a = cmd.Split(',')[1];
                                string files = null;
                                string directories = null;
                                if (Directory.Exists(a))
                                {
                                    string[] grabdirectories = Directory.GetDirectories(@a);
                                    string[] grabfiles = Directory.GetFiles(@a);

                                    foreach (string name in grabdirectories)
                                    {
                                        directories += name + " (DIR)" + System.Environment.NewLine;
                                    }
                                    foreach (string namez in grabfiles)
                                    {


                                        files += namez + " (FILE)" + System.Environment.NewLine;
                                    }
                                    Console.WriteLine(directories + files);
                                }
                                else if (Directory.Exists(defPath + "\\" + a))
                                {
                                    string[] grabdirectories = Directory.GetDirectories(@defPath + "\\" + a);
                                    string[] grabfiles = Directory.GetFiles(@defPath + "\\" + a);

                                    foreach (string name in grabdirectories)
                                    {
                                        directories += name + " (DIR)" + System.Environment.NewLine;
                                    }
                                    foreach (string namez in grabfiles)
                                    {


                                        files += namez + " (FILE)" + System.Environment.NewLine;
                                    }
                                    Console.WriteLine(directories + files);
                                }
                                else
                                {
                                    Console.WriteLine("Directory does not exist. Please try again.");
                                }

                            }

                            else if (cmd.Contains("cd") && cmd.Contains(","))
                            {
                                string a = cmd.Split(',')[1];
                                var dir = new DirectoryInfo(defPath);
                                if (a == "../")
								{
                                    if (Directory.Exists(dir.Parent.FullName))
                                        defPath = dir.Parent.FullName;
								}
                                else if (a == "..")
                                {
                                    if (Directory.Exists(dir.Parent.FullName))
                                        defPath = dir.Parent.FullName;
                                }
                                else if (Directory.Exists(a))
                                {
                                    defPath = a;
                                }
                                else if (Directory.Exists(defPath + "\\" + a))
                                {
                                    defPath = defPath + "\\" + a;
                                }
                                
                                else
                                {
                                    Console.WriteLine("Directory does not exist. Please try again.");
                                    Console.WriteLine("Use the command \"cdhelp\" for help on using the command.");
                                }

                            }

                            else if (cmd.Contains("cdhelp"))
							{
                                Console.WriteLine("You can either use full paths or directory names to navigate into different directories/paths.");
                                Console.WriteLine("Example: cd,C:\\Users\\Slink\\Desktop");
                                Console.WriteLine("Example: cd,Folder1 | (will go into Folder 1 in C:\\Users\\Slink\\Desktop");
                                Console.WriteLine("Example: cd,../ | to go back one directory.");
							}

                            else if (cmd.Contains("ls") && !cmd.Contains(","))
                            {
                                string files = null;
                                string directories = null;
                                if (Directory.Exists(defPath))
                                {
                                    string[] grabdirectories = Directory.GetDirectories(@defPath);
                                    string[] grabfiles = Directory.GetFiles(@defPath);

                                    foreach (string name in grabdirectories)
                                    {
                                        directories += name + " (DIR)" + System.Environment.NewLine;
                                    }
                                    foreach (string namez in grabfiles)
                                    {


                                        files += namez + " (FILE)" + System.Environment.NewLine;
                                    }
                                    Console.WriteLine(directories + files);
                                }
                                else
                                {
                                    Console.WriteLine("Directory does not exist. Please try again.");
                                }

                            }

                            else if (cmd.Contains("del") && cmd.Contains(","))
                            {
                                string a = cmd.Split(',')[1];
                                if (File.Exists(a))
                                {
                                    File.Delete(a);
                                }
                                else if (File.Exists(defPath + "\\" + a))
                                {
                                    File.Delete(defPath + "\\" + a);

                                }
                                else
                                {
                                    Console.WriteLine("File does not exist. Please try again.");
                                    Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                }
                            }

                            else if (cmd.Contains("rm") && cmd.Contains(","))
                            {
                                string a = cmd.Split(',')[1];
                                if (Directory.Exists(a))
                                {
                                    Directory.Delete(a, true);
                                }
                                else if (Directory.Exists(defPath + "\\" + a))
                                {
                                    Directory.Delete(defPath + "\\" + a,true);

                                }
                                else
                                {
                                    Console.WriteLine("Directory does not exist. Please try again.");
                                    Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                }
                            }
                            else if (cmd.Contains("fcolor") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];

                                if (a == "black")
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                }
                                else if (a == "blue")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                }
                                else if (a == "cyan")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Clear();
                                }
                                else if (a == "darkblue")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Clear();
                                }
                                else if (a == "darkcyan")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Clear();
                                }
                                else if (a == "darkgray")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Clear();
                                }
                                else if (a == "darkgreen")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Clear();
                                }
                                else if (a == "darkmagenta")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Clear();
                                }
                                else if (a == "darkred")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                }
                                else if (a == "darkyellow")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                }
                                else if (a == "gray")
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Clear();
                                }
                                else if (a == "green")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                }
                                else if (a == "magenta")
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Clear();
                                }
                                else if (a == "red")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                }
                                else if (a == "white")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                }
                                else if (a == "yellow")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid color. Use \"listcolors\" for a list of colors to customize terminal with.");
                                }
                            }

                            else if (cmd.Contains("bcolor") && cmd.Contains(" "))
                            {
                                string a = cmd.Split(' ')[1];

                                if (a == "black")
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                }
                                else if (a == "blue")
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                }
                                else if (a == "cyan")
                                {
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                    Console.Clear();
                                }
                                else if (a == "darkblue")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.Clear();
                                }
                                else if (a == "darkcyan")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                                    Console.Clear();
                                }
                                else if (a == "darkgray")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                    Console.Clear();
                                }
                                else if (a == "darkgreen")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.Clear();
                                }
                                else if (a == "darkmagenta")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.Clear();
                                }
                                else if (a == "darkred")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                }
                                else if (a == "darkyellow")
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                }
                                else if (a == "gray")
                                {
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    Console.Clear();
                                }
                                else if (a == "green")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                }
                                else if (a == "magenta")
                                {
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    Console.Clear();
                                }
                                else if (a == "red")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                }
                                else if (a == "white")
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                }
                                else if (a == "yellow")
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                }

                                else
                                {
                                    Console.WriteLine("Invalid color. Use \"listcolors\" for a list of colors to customize terminal with.");
                                }
                            }

                            else if (cmd.Contains("copyfile") && cmd.Contains(","))
                            {
                                if (cmd == "copyfile,,")
                                    Console.WriteLine("Error: using copyfile command incorrectly!");
                                else
                                {
                                    string fileToCopy = cmd.Split(',')[1];
                                    string fileDestination = "";
                                    try
                                    {
                                        fileDestination = cmd.Split(',')[2];
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("Error: Make sure copyfile is in the correct format!");
                                    }
                                    if (fileToCopy == "")
                                    {
                                        Console.WriteLine("Error: File to copy is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else if (fileDestination == "")
                                    {
                                        Console.WriteLine("Error: Destination to copy the file to is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else
                                    {
                                        if (File.Exists(defPath + "\\" + fileToCopy))
                                        {
                                            try
                                            {
                                                File.Move(defPath + "\\" + fileToCopy, defPath + "\\" + fileDestination + Path.GetFileName(defPath + "\\" + fileToCopy));
                                            }
                                            catch (Exception e)
                                            {
                                                // do this one instead
                                                File.Move(defPath + "\\" + fileToCopy, fileDestination + Path.GetFileName(defPath + "\\" + fileToCopy));
                                            }

                                        }
                                        else if (File.Exists(fileToCopy) == false)
                                        {
                                            Console.WriteLine("Error: File to copy does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else if (Directory.Exists(fileDestination) == false)
                                        {
                                            Console.WriteLine("Error: Destination to copy the file does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else
                                        {
                                            File.Copy(fileToCopy, fileDestination + Path.GetFileName(fileToCopy), true);
                                            Console.WriteLine(fileToCopy + " has been copied to: " + fileDestination + ".");
                                        }
                                    }
                                }
                            }

                            else if (cmd.Contains("movefile") && cmd.Contains(","))
                            {
                                if (cmd == "movefile,,")
                                    Console.WriteLine("Error: using movefile command incorrectly!");
                                else
                                {
                                    string fileToMove = cmd.Split(',')[1];
                                    string fileDestination = "";
                                    try
                                    {
                                        fileDestination = cmd.Split(',')[2];
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("Error: Make sure movefile is in the correct format!");
                                    }
                                    if (fileToMove == "")
                                    {
                                        Console.WriteLine("Error: File to move is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else if (fileDestination == "")
                                    {
                                        Console.WriteLine("Error: Destination to move the file to is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else
                                    {
                                        if (File.Exists(defPath + "\\" + fileToMove))
                                        {
                                            try
                                            {
                                                File.Move(defPath + "\\" + fileToMove, defPath + "\\" + fileDestination + Path.GetFileName(defPath + "\\" + fileToMove));
                                            }
                                            catch (Exception e)
											{
                                                // do this one instead
                                                File.Move(defPath + "\\" + fileToMove, fileDestination + Path.GetFileName(defPath + "\\" + fileToMove));
                                            }

                                        }
                                        else if (File.Exists(fileToMove) == false)
                                        {
                                            Console.WriteLine("Error: File to move does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else if (Directory.Exists(fileDestination) == false)
                                        {
                                            Console.WriteLine("Error: Destination to move the file does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else
                                        {
                                            File.Move(fileToMove, fileDestination + Path.GetFileName(fileToMove));
                                            Console.WriteLine(fileToMove + " has been moved to: " + fileDestination + ".");
                                        }
                                    }
                                }
                            }

                            else if (cmd.Contains("movedir") && cmd.Contains(","))
                            {
                                if (cmd == "movedir,,")
                                    Console.WriteLine("Error: using movedir command incorrectly!");
                                else
                                {
                                    string dirToMove = cmd.Split(',')[1];
                                    string dirDestination = "";
                                    try
                                    {
                                        dirDestination = cmd.Split(',')[2];
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("Error: Make sure movedir is in the correct format!");
                                    }
                                    if (dirToMove == "")
                                    {
                                        Console.WriteLine("Error: Directory to move is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else if (dirDestination == "")
                                    {
                                        Console.WriteLine("Error: Destination to move the directory to is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else
                                    {
                                        if (Directory.Exists(dirToMove) == false)
                                        {
                                            Console.WriteLine("Error: Directory to move does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else if (Directory.Exists(dirDestination) == false)
                                        {
                                            Console.WriteLine("Error: Destination to move the directory does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if (Directory.Exists(dirDestination + Path.GetFileName(Path.GetDirectoryName(dirToMove))))
                                                    Directory.Delete(dirDestination + Path.GetFileName(Path.GetDirectoryName(dirToMove)), true);

                                                Directory.Move(dirToMove, dirDestination + Path.GetFileName(Path.GetDirectoryName(dirToMove)));
                                                Console.WriteLine(dirToMove + " has been moved to: " + dirDestination + ".");
                                            }
                                            catch (IOException)
                                            {
                                                Console.WriteLine("Error: Please make sure the directory paths are in the correct"
                                                    + " format! Example: movedir,c:\\users\\testUser\\desktop\\test folder\\folder 1\\,"
                                                    + "c:\\users\\testUser\\desktop\\");
                                            }
                                        }
                                    }
                                }
                            }

                            else if (cmd.Contains("copydir") && cmd.Contains(","))
                            {
                                if (cmd == "copydir,,")
                                    Console.WriteLine("Error: using copydir command incorrectly!");
                                else
                                {
                                    string dirToCopy = cmd.Split(',')[1];
                                    string dirDestination = "";
                                    try
                                    {
                                        dirDestination = cmd.Split(',')[2];
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("Error: Make sure copydir is in the correct format!");
                                    }
                                    if (dirToCopy == "")
                                    {
                                        Console.WriteLine("Error: Directory to copy is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else if (dirDestination == "")
                                    {
                                        Console.WriteLine("Error: Destination to copy the directory to is not specified!");
                                        Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                    }
                                    else
                                    {
                                        if (Directory.Exists(dirToCopy) == false)
                                        {
                                            Console.WriteLine("Error: Directory to copy does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else if (Directory.Exists(dirDestination) == false)
                                        {
                                            Console.WriteLine("Error: Destination to copy the directory does not exist!");
                                            Console.WriteLine("Use 'fileiohelp' command to see formatting for usage of file and directory commands.");
                                        }
                                        else
                                        {
                                            try
                                            {
                                                string dirName = Path.GetFileName(Path.GetDirectoryName(dirToCopy));
                                                if (Directory.Exists(dirDestination + dirName))
                                                    Directory.Delete((dirDestination + dirName), true);
                                                Directory.CreateDirectory(dirDestination + dirName);
                                                string[] files = Directory.GetFiles(dirToCopy);
                                                foreach (string f in files)
                                                {
                                                    File.Copy(f, ((dirDestination + dirName) + "\\" + Path.GetFileName(f)), true);
                                                }
                                                Console.WriteLine(dirToCopy + " has been copied to: " + dirDestination + ".");
                                            }
                                            catch (IOException)
                                            {
                                                Console.WriteLine("Error: Please make sure the directory paths are in the correct"
                                                    + " format! Example: copydir,c:\\users\\testUser\\desktop\\test folder\\folder 1\\,"
                                                    + "c:\\users\\testUser\\desktop\\");
                                            }

                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(cmd + " is not a supported command or is being used incorrectly. "
                                                   + "Please use \"help\" for a list of basic commands.");
                            }
                            break;
                        }
                }

            #endregion
            }
     
        }


    }
}
