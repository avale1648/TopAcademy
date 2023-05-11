namespace NP6hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 300_000;//��������� ��� � ���� ����� (5 ��� = 5 * 60 � = 5 * 60 * 1000 ��);
            timer_Tick(sender, e);//��������� ��������� ����������;
            timer.Start();//������ �������;
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            await Weather.GetDataFromOpenWeatherMap();//��������� ���������� � ������ � OpenWeatherMap;
            pictureBoxIcon.ImageLocation = Weather.Icon;//�������� ���������� �� ������ ��������;
            label.Text = $"{Weather.Description}, {Weather.Temperature}";//�������� ���������� � ������ � �����;
            Text = "������ � ������, " + label.Text;//�������� ���������� � ������ � ��������� �����;
        }
    }
}