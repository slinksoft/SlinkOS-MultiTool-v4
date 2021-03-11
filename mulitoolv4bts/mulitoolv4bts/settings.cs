using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace slinkosmtv4
{
    public partial class settings : Form
    {
        bool installed;

        //settings vars
        string uname;
        bool paintopen;
        bool ifversioncheck;
        bool ifStartup;
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\")) // finds if registry keys exists already so it will not overwrite incorrect value.
            {
                string findkey = (string)Key.GetValue("SlinkOS");
                if (findkey == null)
                {
                    installed = false;
                    installButton.Text = "Install";
                    unInput.Enabled = false;
                    checkVersion.Enabled = false;
                    paintOpenOp.Enabled = false;
                    saveButton.Enabled = false;
                    noStartup.Enabled = false;
                }
                else
                {
                    installed = true;
                    installButton.Text = "Uninstall";
                    unInput.Enabled = true;
                    checkVersion.Enabled = true;
                    paintOpenOp.Enabled = true;
                    saveButton.Enabled = true;
                    noStartup.Enabled = true;

                    StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                    uname = read.ReadLine();
                    paintopen = Convert.ToBoolean(read.ReadLine());
                    ifversioncheck = Convert.ToBoolean(read.ReadLine());
                    ifStartup = Convert.ToBoolean(read.ReadLine());

                    unInput.Text = uname;
                    if (paintopen == true)
                    {
                        paintOpenOp.Checked = true;
                    }
                    
                    if (ifversioncheck == true)
                    {
                        checkVersion.Checked = true;
                    }
                    if (ifStartup == true)
                    {
                        noStartup.Checked = true;
                    }
                    read.Close();


                }
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            if (installed == false)
            {
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS") == false)
                {
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS");
                    File.Copy("slinkosmtv4.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\slinkosmtv4.exe");
                    File.Copy("AxInterop.WMPLib.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\AxInterop.WMPLib.dll");
                    File.Copy("cef.pak", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\cef.pak");
                    File.Copy("cef_100_percent.pak", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\cef_100_percent.pak");
                    File.Copy("cef_200_percent.pak", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\cef_200_percent.pak");
                    File.Copy("cef_extensions.pak", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\cef_extensions.pak");
                    File.Copy("CefSharp.BrowserSubprocess.Core.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.BrowserSubprocess.Core.dll");
                    File.Copy("CefSharp.BrowserSubprocess.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.BrowserSubprocess.exe");
                    File.Copy("CefSharp.Core.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.Core.dll");
                    File.Copy("CefSharp.Core.xml", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.Core.xml");
                    File.Copy("CefSharp.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.dll");
                    File.Copy("CefSharp.WinForms.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.WinForms.dll");
                    File.Copy("CefSharp.WinForms.XML", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.WinForms.XML");
                    File.Copy("CefSharp.XML", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\CefSharp.XML");
                    File.Copy("chrome_elf.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\chrome_elf.dll");
                    File.Copy("d3dcompiler_47.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\d3dcompiler_47.dll");
                    File.Copy("devtools_resources.pak", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\devtools_resources.pak");
                    File.Copy("icudtl.dat", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\icudtl.dat");
                    File.Copy("Interop.WMPLib.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\Interop.WMPLib.dll");
                    File.Copy("libcef.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\libcef.dll");
                    File.Copy("libEGL.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\libEGL.dll");
                    File.Copy("libGLESv2.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\libGLESv2.dll");
                    File.Copy("natives_blob.bin", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\natives_blob.bin");
                    File.Copy("snapshot_blob.bin", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\snapshot_blob.bin");
                    File.Copy("v8_context_snapshot.bin", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\v8_context_snapshot.bin");
                    File.Copy("pkge", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\pkge.exe");
                    File.Copy("NCalc.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\NCalc.dll");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\locales\\");
                    string[] files = Directory.GetFiles("locales\\");
                    foreach (string f in files)
                    {
                        File.Copy(f, (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\locales\\" + Path.GetFileName(f)), true);
                    }
                }

                RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                add.SetValue("SlinkOS", "\"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\slinkosmtv4.exe" + "\"");
                MessageBox.Show("Installed. MultiTool v4/SlinkOS restarting...", "Installed");
                installButton.Text = "Uninstall";
                installed = true;
                unInput.Enabled = true;
                checkVersion.Enabled = true;
                paintOpenOp.Enabled = true;
                saveButton.Enabled = true;
                noStartup.Enabled = true;

                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                write.WriteLine(unInput.Text);
                write.WriteLine(paintopen);
                write.WriteLine(ifversioncheck);
                write.WriteLine(ifStartup);
                write.Close();
                MessageBox.Show("Restarting...", "SlinkOS Installation");
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\slinkosmtv4.exe");
                Application.Exit();
            }
            else if (installed == true)
            {
                RegistryKey del = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                del.DeleteValue("SlinkOS");
                MessageBox.Show("Uninstalled. Please restart MultiTool v4/SlinkOS (the portable/downloaded executable that you initially downloaded) for the uninstallation/cleanup to complete.", "Uninstalled");
                installButton.Text = "Install";
                installed = false;
                unInput.Enabled = false;
                checkVersion.Enabled = false;
                paintOpenOp.Enabled = false;
                saveButton.Enabled = false;
                noStartup.Enabled = false;
                Environment.Exit(0);
                //Application.Exit();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
            write.WriteLine(unInput.Text);
            write.WriteLine(paintopen);
            write.WriteLine(ifversioncheck);
            write.WriteLine(ifStartup);
            write.Close();
            MessageBox.Show("Restarting...", "SlinkOS");
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\slinkosmtv4.exe");
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paintOpenOp_CheckedChanged(object sender, EventArgs e)
        {
            if (paintOpenOp.Checked == true)
            {
                paintopen = true;
            }
            else
            {
                paintopen = false;
            }
        }

        private void checkVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVersion.Checked == true)
            {
                ifversioncheck = true;
            }
            else
            {
                ifversioncheck = false;
            }
        }

        private void showCredits_Click(object sender, EventArgs e)
        {
            slinkoscredits openme = new slinkoscredits();
            openme.Show();
        }

        private void NoStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (noStartup.Checked == true)
            {
                ifStartup = true;
            }
            else
            {
                ifStartup = false;
            }
        }
    }
}
