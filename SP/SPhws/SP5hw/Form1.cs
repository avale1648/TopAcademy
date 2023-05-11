using System.Drawing.Text;
namespace SP5hw
{
    public partial class Form1 : Form
    {
        private bool isFormClosed = false;//флаг дл€ завершени€ цикла в случае закрыти€ формы
        private bool isEnabledToWrite = false;//флаг, определ€ющий, разрешена ли запись в файл
        private List<string> mouseEnters = new List<string>();//коллекци€ строк с позицией мыши и временем
        private StreamWriter streamWriter = new StreamWriter("mouseEnters.txt", true);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Text = $"({Cursor.Position.X}, {Cursor.Position.Y}) {DateTime.Now}";//запись позиции в текст формы
            mouseEnters.Add(this.Text);//добавление позиции и времени в коллекцию
            isEnabledToWrite = true;//разрешение на запись в файл
        }
        private void Write()
        {
            while (true)
            {
                //выход из цикла
                if (isFormClosed)
                    break;
                if(isEnabledToWrite)//если запись в файл разрешена
                {
                    streamWriter.WriteLine(mouseEnters.Last().ToString());//запись в файл
                    isEnabledToWrite = false;//запрет на запись в файл 
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(Write).Start();//запуск потока на запись в файл
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosed = true;//завершение цикла
            streamWriter.Close();//закрытие записи из потока
        }
    }
}