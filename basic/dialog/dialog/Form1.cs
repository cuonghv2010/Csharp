using System.Drawing;

namespace dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            string str = result.ToString();
            string path = "";
            path = this.folderBrowserDialog1.SelectedPath;
            if (result == DialogResult.OK)
            {
                if (path == "")
                {
                    MessageBox.Show("Result: " + str, "Empty path",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.textBox1.Text = path;
                    if (path == "")
                    {
                        MessageBox.Show("Result: " + str, "Empty path");
                    }
                    else
                    {
                        this.textBox1.Text = path;
                        MessageBox.Show("Result:" + str, "OK");
                    }
                }
            }
            else
            {
                MessageBox.Show("Result:" + str, "Open failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            string fileName = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(fileName);
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.textBox2.Text = fileName;
        }
        
    }
}