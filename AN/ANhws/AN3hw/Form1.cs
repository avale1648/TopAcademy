using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
namespace AN3hw
{
    public partial class Form1 : Form
    {
        private SqlConnection posterConnection = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private string filename = string.Empty;
        public Form1()
        {
            InitializeComponent();
            posterConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Poster"].ConnectionString);
        }
        private byte[] Copy()
        {
            Image i = Image.FromFile(filename);
            int maxWidth = 300, maxHeight = 300;
            double ratioX = (double)maxWidth / i.Width;
            double ratioY = (double)maxHeight / i.Height;
            double ratio = Math.Min(ratioX, ratioY);
            Image mi = new Bitmap((int)(i.Width * ratio), (int)(i.Height * ratio));
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(i, 0, 0, (int)(i.Width * ratio), (int)(i.Height * ratio));
            MemoryStream ms = new MemoryStream();
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] bytes = br.ReadBytes((int)ms.Length);
            return bytes;
        }
        private void LoadPicture()
        {
            try
            {
                byte[] bytes = Copy();
                posterConnection.Open();
                SqlCommand sc = new SqlCommand("insert into Pictures(Name_, Picture, EventId) values (@name, @picture, @eventId)", posterConnection);
                if (toolStripTextBox1.Text == null || toolStripTextBox1.Text.Length == 0) return;
                    int i = -1;
                int.TryParse(toolStripTextBox1.Text, out i);
                if (i == -1)
                    return;
                sc.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = filename;
                sc.Parameters.Add("@picture", SqlDbType.Image, bytes.Length).Value = bytes;
                sc.Parameters.Add("@eventId", SqlDbType.Int).Value = i;
                sc.ExecuteNonQuery();
                posterConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (posterConnection != null)
                    posterConnection.Close();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics Files|*.*";
            ofd.FileName = string.Empty;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                filename = ofd.FileName;
                LoadPicture();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(toolStripTextBox1.Text == null||toolStripTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("Please enter event's id.");
                }
                int i = -1;
                int.TryParse(toolStripTextBox1.Text, out i);
                if (i == -1)
                {
                    MessageBox.Show("Please enter event's id in correct formate.");
                    return;
                }
                sda = new SqlDataAdapter("select Picture from Pictures where EventId =@id", posterConnection);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = i;
                ds = new DataSet();
                sda.Fill(ds);
                byte[] bs = (byte[])ds.Tables[0].Rows[0]["Picture"];
                MemoryStream ms = new MemoryStream(bs);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("select *  from Pictures", posterConnection);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Picture");
                dataGridView1.DataSource = ds.Tables["Picture"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
