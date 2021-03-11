using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace slinkosmtv4
{ /* this class is called upon Program.cs (that starts up the application, or SlinkOS) and will close
    the initial console output window.*/
    class CloseInitialConsoleWindow
    {
        // import kernel32.dll to grab flags that capture the console window and allow showing/hiding
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0; // value for hide

        public CloseInitialConsoleWindow()
        {
            var handle = GetConsoleWindow(); // capture console window and store it in handle
            // Hide
            ShowWindow(handle, SW_HIDE); // hide console window
        }
    }
}
