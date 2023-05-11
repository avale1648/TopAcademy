using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////
using System.Management;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Diagnostics;
namespace SP3cwParent
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
            LoadAvailableAssemblies();
        }
        const uint WM_SETTEXT = 0x0c;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);
        List<Process> processes = new List<Process>();
        int counter = 0;
        void LoadAvailableAssemblies()
        {
            string except = new FileInfo(Application.ExecutablePath).Name;
            except = except.Substring(0, except.IndexOf("."));
            string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
            foreach (var file in files)
            {
                string fileName = new FileInfo(file).Name;
                if (fileName.IndexOf(except) == -1)
                    AvailableAssemblies.Items.Add(fileName);
            }
        }
        void RunProcess(string AssemblyName)
        {
            Process p = Process.Start(AssemblyName);
            processes.Add(p);
            if (Process.GetCurrentProcess().Id == GetParentProcessId(p.Id))
            {
                MessageBox.Show(p.ProcessName + "really child process");
                p.EnableRaisingEvents = true;
                SetChildWindowText(p.MainWindowHandle, "Child Process #" + (++counter));
                if (!StartAssemblies.Items.Contains(p.ProcessName))
                    StartAssemblies.Items.Add(p.ProcessName);
                AvailableAssemblies.Items.Remove(AvailableAssemblies.SelectedItem);
            }
        }
        void SetChildWindowText(IntPtr Handle, string text)
        {
            SendMessage(Handle, WM_SETTEXT, 0, text);
        }
        int GetParentProcessId(int ID)
        {
            int parentID = 0;
            using(ManagementObject mo = new ManagementObject("win32_process.handle=" + ID.ToString()))
            {
                mo.Get();
                parentID = Convert.ToInt32(mo["ParentProcessId"]);
            }
            return parentID;
        }
        void ProcessExited(object sender, EventArgs e)
        {
            Process p = sender as Process;
            StartAssemblies.Items.Remove(p.ProcessName);
            AvailableAssemblies.Items.Add(p.ProcessName);
            processes.Remove(p);
            counter--;
            int index = 0;
            foreach (var p1 in processes)
                SetChildWindowText(p1.MainWindowHandle, "Child Process #" + ++index);
        }
        delegate void ProcessDelegate(Process p);
        void ExecuteOnProcessesByName(string processName, ProcessDelegate func)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach(var p in processes)
            if(Process.GetCurrentProcess().Id == GetParentProcessId(p.Id))
                    func(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void StartAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AvailableAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}