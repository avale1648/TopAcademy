namespace SP3cw
{
    public partial class Form1 : Form
    {
        private Mutex mutex = new Mutex();
        private const int ThreadsNumber = 4;
        ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ThreadsNumber; i++)
                new Thread(Increment).Start();
            VoidFunc1();
        }
        private void Increment()
        {

            for (int i = 0; i < progressBar1.Maximum / ThreadsNumber; i++)
            {
                mutex.WaitOne();
                progressBar1.Value++;
                mutex.ReleaseMutex();
            }
        }
        private void VoidFunc1()
        {
            for (int i = 0; i < ThreadsNumber; i++)
            {
                new Thread(Manual).Start();
            }
        }
        private void Auto()
        {

        }
        private void Manual()
        {
            manualResetEvent.WaitOne();
            for (int i = 1; i <= 101; i++)
                label1.Text = i.ToString() + " ";
            manualResetEvent.Reset();
        }
    }
}