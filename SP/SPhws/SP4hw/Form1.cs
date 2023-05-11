namespace SP4hw
{
    public partial class Form1 : Form
    {
        private Semaphore semaphore = new Semaphore(1, 4);
        private int currentIndex = 0;
        private ProgressBar[] progressBars = new ProgressBar[4];
        Stream @in = File.OpenRead("in.dat");

        public Form1()
        {
            InitializeComponent();
        }
        private void Copy()
        {
            semaphore.WaitOne();
            byte[] buffer = new byte[1024];
            int total = 0;
            using (Stream @out = File.Create(currentIndex + "out.dat"))
            {
                using (@in = File.OpenRead("in.dat"))
                {
                    int read = @in.Read(buffer, 0, buffer.Length);
                    @out.Write(buffer, 0, read);
                    total += read;
                    progressBars[currentIndex].Invoke(() => progressBars[currentIndex].Value = total);
                    progressBar0.Invoke(() => progressBar0.Value += total);
                }
                if(currentIndex < progressBars.Length - 1)
                currentIndex++;
            }
            semaphore.Release();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBars[0] = progressBar1;
            progressBars[1] = progressBar2;
            progressBars[2] = progressBar3;
            progressBars[3] = progressBar4;
            foreach (var progressBar in progressBars)
                progressBar.Maximum = (int)@in.Length;
            progressBar0.Maximum = 4 * progressBars[0].Maximum;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < progressBars.Length; i++)
            {
                new Thread(Copy).Start();
            }
        }
    }
}