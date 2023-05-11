using System.Drawing.Text;
namespace SP5hw
{
    public partial class Form1 : Form
    {
        private bool isFormClosed = false;//���� ��� ���������� ����� � ������ �������� �����
        private bool isEnabledToWrite = false;//����, ������������, ��������� �� ������ � ����
        private List<string> mouseEnters = new List<string>();//��������� ����� � �������� ���� � ��������
        private StreamWriter streamWriter = new StreamWriter("mouseEnters.txt", true);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Text = $"({Cursor.Position.X}, {Cursor.Position.Y}) {DateTime.Now}";//������ ������� � ����� �����
            mouseEnters.Add(this.Text);//���������� ������� � ������� � ���������
            isEnabledToWrite = true;//���������� �� ������ � ����
        }
        private void Write()
        {
            while (true)
            {
                //����� �� �����
                if (isFormClosed)
                    break;
                if(isEnabledToWrite)//���� ������ � ���� ���������
                {
                    streamWriter.WriteLine(mouseEnters.Last().ToString());//������ � ����
                    isEnabledToWrite = false;//������ �� ������ � ���� 
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(Write).Start();//������ ������ �� ������ � ����
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosed = true;//���������� �����
            streamWriter.Close();//�������� ������ �� ������
        }
    }
}