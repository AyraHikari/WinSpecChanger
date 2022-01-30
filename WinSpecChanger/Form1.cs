using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinSpecChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Permament changes
            string ManuReal = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", null);
            string ModReal = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", null);

            // Temporary changes
            string ProcReal = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", null);

            ManBox.Text = ManuReal;
            ModelBox.Text = ModReal;
            ProcBox.Text = ProcReal;
        }

        private void PermSave_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", ManBox.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", ModelBox.Text);

            MessageBox.Show("Saved!");
        }

        private void TempSave_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", ProcBox.Text);

            MessageBox.Show("Temporary saved!\nValue will be reset after reboot.");
        }
    }
}
