using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel.Design;
using static System.Console;
// подключение через файл App.config
using System.Configuration;
// для WF
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace classwork3_WindowsForms_picturesAdd
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;
        string filename = "";
        string sqlConnectionString = ConfigurationManager.ConnectionStrings["CustomersAdd"].ConnectionString;

        public Form1()
        {
            InitializeComponent();

            // связь с БД
            conn = new SqlConnection(sqlConnectionString);
        }


        private void LoadPicture()
        {
            try
            {
                byte[] bytes = CreateCopy();
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Pictures (Customer_ID, _Name,Picture) values (@Customer_ID, @_Name, @Picture);", conn);
                if (toolStripTextBox1.Text == null || toolStripTextBox1.Text.Length == 0) return;
                int index = -1;
                int.TryParse(toolStripTextBox1.Text, out index);
                if (index == -1) return;
                comm.Parameters.Add("@Customer_ID", SqlDbType.Int).Value = index;
                comm.Parameters.Add("@_Name", SqlDbType.NVarChar, 255).Value = filename;
                comm.Parameters.Add("@Picture", SqlDbType.Image, bytes.Length).Value = bytes;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        private byte[] CreateCopy()
        {
            Image img = Image.FromFile(filename);
            int maxWidth = 300, maxHeight = 300; 
            
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight); 
            
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush(); // очищение потока памяти от предыдущего объекта
            ms.Seek(0, SeekOrigin.Begin); // устанавливает стартовую позицию курсора для чтения
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        } 

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Graphics Files|*.*";
            //openFD.Filter = "Graphics Files|*.bmp, *.jpg, *.png, *.gif, *.jpeg";
            openFD.FileName = "";
            if(openFD.ShowDialog()==DialogResult.OK)
            {
                filename = openFD.FileName;
                LoadPicture();
            }
        }

        private void showOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTextBox1.Text == null || toolStripTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("Укажите ID покупателя!");
                    return;
                }
                
                int index = -1;
                int.TryParse(toolStripTextBox1.Text, out index);
                
                if(index == -1)
                {
                    MessageBox.Show("Укажите ID покупателя в правильном формате!");
                    return;
                }

                dataAdapter = new SqlDataAdapter("select Picture from Pictures where Customer_ID=@ID", conn);
                SqlCommandBuilder cmb = new SqlCommandBuilder(dataAdapter);

                dataAdapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = index;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                byte[] bytes = (byte[])dataSet.Tables[0].Rows[0]["Picture"];
                MemoryStream ms = new MemoryStream(bytes);

                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // проверка, что вводимые данные именно цифры
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter = new SqlDataAdapter("select * from Pictures;", conn);
                SqlCommandBuilder cmb = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "picture");
                dataGridView1.DataSource = dataSet.Tables["picture"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
