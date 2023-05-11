using System.Globalization;

namespace SP6hw
{
    public partial class Form1 : Form
    {
        private const int Maximum = 100;
        private bool isException = false;//флаг дл€ симул€ции исключени€
        CancellationTokenSource cancel = new CancellationTokenSource();
        private ProgressBar[] progressBars;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBars = new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4 };
            foreach (var progressBar in progressBars)
                progressBar.Maximum = Maximum;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancel.Cancel();//отмена
        }
        private void buttonException_Click(object sender, EventArgs e)
        {
            isException = true;//перевод флага в состо€ние истины
        }
        private void Increment(int index, CancellationToken token)
        {
            try
            {
                while (progressBars[index].Value < progressBars[index].Maximum)
                {
                    if (token.IsCancellationRequested)//если была запрошена отмена, то:
                        token.ThrowIfCancellationRequested();//выдать исключение об отмене операции
                    if (isException)
                    {
                        throw new Exception("Exception");
                        cancel.Cancel();
                    }
                    Thread.Sleep(200);
                    progressBars[index].Invoke(() => progressBars[index].Value++);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Start()
        {
            CancellationToken token = cancel.Token;
            Task[] tasks = new Task[4];
            for (int i = 0; i < 4; i++)
            {
                    int j = i;
                    tasks[i] = Task.Run(() => Increment(j, token), token);
            }
            Task.WhenAll(tasks).ContinueWith(tasks =>
                MessageBox.Show("Files copying is finished!", "Files Copying is Finished!", MessageBoxButtons.OK));
        }
    }
}