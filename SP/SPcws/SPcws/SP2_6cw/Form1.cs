using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SP2_6cw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(new NamedProcess(p, p.ProcessName));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NamedProcess clicked = (NamedProcess)listBox1.SelectedItem;
            if (clicked is null) return;
            SetText(clicked.P.MainWindowHandle, textBox1.Text);
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint message,
        int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam); public const uint WM_SETTEXT = 0x0c;
        public static void SetText(IntPtr hwnd, string text)
        {
            SendMessage(hwnd, WM_SETTEXT, 0, text);
        }
    }
    public class NamedProcess
    {
        public Process P { get; set; }
        public string S { get; set; }
        public NamedProcess(Process p, string s)
        {
            P = p;
            S = s;
        }
        public override string ToString() => S;
    }
}