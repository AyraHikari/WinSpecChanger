using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinSpecChanger
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                string help = "Command info:\n  -c \"CPU info\"\n\nExample:\n   WinSpecChanger -c \"Intel(R) Core(TM) i3-12100 CPU @ 4.30Hz\"";
                if (args[0] == "-c")
                {
                    string CPUFake = args[1];
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", CPUFake);
                } else
                {
                    MessageBox.Show(help);
                }
            }
        }
    }
}
