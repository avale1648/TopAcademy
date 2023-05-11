using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SP8hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser;
            registryKey = registryKey.CreateSubKey("Software");
            registryKey = registryKey.CreateSubKey("SystemProgramming");
            registryKey = registryKey.CreateSubKey("SP8hw");
            Width = (int)registryKey.GetValue("width", 812);
            Height = (int)registryKey.GetValue("height", 489);
            Left = (int)registryKey.GetValue("left", 50);
            Top = (int)registryKey.GetValue("top", 50);
            WindowState = (FormWindowState)registryKey.GetValue("windowState", FormWindowState.Normal);
            registryKey.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Microsoft.Win32.RegistryKey registryKey= Microsoft.Win32.Registry.CurrentUser;
            registryKey = registryKey.CreateSubKey("Software");
            registryKey = registryKey.CreateSubKey("SystemProgramming");
            registryKey = registryKey.CreateSubKey("SP8hw");
            registryKey.SetValue("windowState", (int)WindowState);
            if(WindowState == FormWindowState.Normal)
            {
                registryKey.SetValue("width", Width);
                registryKey.SetValue("height", Height);
                registryKey.SetValue("left", Left);
                registryKey.SetValue("top", Top);
            }
        }
    }
}
