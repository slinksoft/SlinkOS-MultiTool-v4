using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace slinkosmtv4
{
    public partial class performance : Form
    {
        PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter disk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        PerformanceCounter handleCount = new PerformanceCounter("Process", "Handle Count", "_Total");
        PerformanceCounter threadCount = new PerformanceCounter("Process", "Thread Count", "_Total");
        public performance()
        {
            InitializeComponent();
        }

        private void updateInfo_Tick(object sender, EventArgs e)
        {
            displayPerform.Text = "RAM Usage\n" + getAvailableRAM() + "\n\nCPU Usage\n" + getCurrentCpuUsage()
                + "\n\nDiskUsage\n" + getCurrentDiskUsage() + "\n\nBattery\n" + getBatteryPercentage()
                + "\n\nThread Count: " + getThread() + "\n\nHandle Count: " + getHandle()
                + "\n\nAvailable disk space (C:\\): " + getDiskSpace("C:\\");
            displayPerform.Location = new System.Drawing.Point(label1.Location.X - (displayPerform.Width/2) + (label1.Width/2), label1.Height + 20);
            this.Size = new System.Drawing.Size(displayPerform.Width + 100, displayPerform.Height + 100);
            label1.Location = new System.Drawing.Point(0 + this.Width / 2 - label1.Width/2 - 10, 5);
            this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        private string getCurrentCpuUsage()
        {
            float result = cpu.NextValue();
            return result.ToString("0.00") + "%";
        }

        private string getAvailableRAM()
        {
            return ram.NextValue() + "MB";
        }

        private string getCurrentDiskUsage()
        {
            float result = disk.NextValue();
            return result.ToString("0.00") + "%";
        }

        private string getThread()
        {
            float result = threadCount.NextValue();
            return result.ToString();
        }

        private string getHandle()
        {
            float result = handleCount.NextValue();
            return result.ToString();
        }

        private string getBatteryPercentage()
        {
            double getDecimal = SystemInformation.PowerStatus.BatteryLifePercent;
            String result = getDecimal.ToString("#0.##%");
            return result;
        }

     
            private string getDiskSpace(string driveName)
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && drive.Name == driveName)
                    {
                        long initialResult = drive.AvailableFreeSpace;
                        double result = initialResult / Math.Pow(2, 30);
                    return result.ToString("0.00") + " GB";
                    }
                }
                return "ERROR LOADING C:\\";
            }

        private void performance_Load(object sender, EventArgs e)
        {
            this.Left -= 100;
            this.Top -= 100;
        }
    }
}
