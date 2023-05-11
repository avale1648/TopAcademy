using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
/////////////////////////
namespace SP2hwTaskManager
{
    public partial class TaskManager : Form
    {
        private List<Process> processes = new List<Process>();
        bool isSortingByID = true;
        public TaskManager()
        {
            InitializeComponent();
        }
        private void TaskManager_Load(object sender, EventArgs e)
        {
            foreach(Process process in Process.GetProcesses())
                processes.Add(process);
            processes.Sort(new ProcessIdComparer());
            foreach (Process p in processes)
            {
                string[] processInfos = new string[]
                {
                    p.Id.ToString(), p.ProcessName.ToString(), p.PrivateMemorySize64.ToString(),
                    p.Threads.ToString(), p.Responding.ToString()
                };
                listView1.Items.Add(new ListViewItem(processInfos));
            }
        }
        private void buttonEndProcess_Click(object sender, EventArgs e)
        {
            string selectedProcessName = listView1.SelectedItems[0].SubItems[1].Text;
            Process[] selectedProcesses = Process.GetProcessesByName(selectedProcessName);
            foreach (Process process in selectedProcesses)
                process.Kill();
            RefreshProcesses();
        }
        private void buttonSortById_Click(object sender, EventArgs e)
        {
            Sort("Id");
            isSortingByID = true;
        }
        private void buttonSortByName_Click(object sender, EventArgs e)
        {
            Sort("Name");
            isSortingByID = false;
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }
        private void Sort(string sortingOption)
        {
            processes.Clear();
            listView1.Items.Clear();
            foreach (Process process in Process.GetProcesses())
                processes.Add(process);
            if(sortingOption == "Id")
                processes.Sort(new ProcessIdComparer());
            if(sortingOption == "Name")
                processes.Sort(new ProcessNameComparer());
            foreach (Process p in processes)
            {
                string[] processInfos = new string[]
                {
                    p.Id.ToString(), p.ProcessName.ToString(), p.PrivateMemorySize64.ToString(),
                    p.Threads.ToString(), p.Responding.ToString()
                };
                listView1.Items.Add(new ListViewItem(processInfos));
            }
        }
        private void RefreshProcesses()
        {
            if (isSortingByID)
                Sort("Id");
            else 
                Sort("Name");
        }
    }
    //Comparers:
    public class ProcessIdComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
    public class ProcessNameComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.ProcessName.CompareTo(y.ProcessName);
        }
    }
}