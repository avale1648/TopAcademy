using System.Diagnostics;

namespace SP2hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(new InfoProcess(p));
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Sort("Name");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Sort("ID");
        }
        private void Sort(string sortingOption)
        {
            List<InfoProcess> tmp = new List<InfoProcess>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tmp.Add((InfoProcess)listBox1.Items[i]);
            }
            if (sortingOption == "ID")
                tmp.Sort(new CompareByID());
            if (sortingOption == "Name")
                tmp.Sort(new CompareByName());
            listBox1.Items.Clear();
            for (int i = 0; i < tmp.Count; i++)
            {
                listBox1.Items.Add(tmp[i]);
            }
        }
        private void toolStripButtonEndProcess_Click(object sender, EventArgs e)
        {
            InfoProcess infoProcess = (InfoProcess)listBox1.SelectedItem;
            infoProcess.Process.Kill();
            listBox1.ClearSelected();
        }
    }
    public class InfoProcess
    {
        public Process Process { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string MemorySize { get; set; }
        public string Threads { get; set; }
        public string HasExited { get; set; }
        public InfoProcess(Process process)
        {
            Process = process;
            ID = process.Id.ToString();
            Name = process.ProcessName;
            MemorySize = process.PrivateMemorySize64.ToString();
            Threads = process.Threads.ToString();
        }
        public override string ToString()
        {
            return $"{ID} {Name} {MemorySize} {Threads} {HasExited}";
        }
    }
    public class CompareByID : IComparer<InfoProcess>
    {
        public int Compare(InfoProcess? x, InfoProcess? y)
        {
            int xi = int.Parse(x.ID);
            int yi = int.Parse(y.ID);
            if (xi > yi) return 1;
            if (xi < yi) return -1;
            else return 0;
        }
    }
    public class CompareByName : IComparer<InfoProcess>
    {
        public int Compare(InfoProcess? x, InfoProcess? y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}