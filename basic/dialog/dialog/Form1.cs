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
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.BMP;*.ico| All files(*.*) | *.*";
            DialogResult result = this.openFileDialog1.ShowDialog();
            string fileName = "";
            fileName = this.openFileDialog1.FileName;
            if (result == DialogResult.OK)
            {
                if (fileName == "")
                {
                    MessageBox.Show("Result: " + result.ToString(), "Empty path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.textBox2.Text = fileName;
                    if (fileName == "")
                    {
                        MessageBox.Show("Result: " + result.ToString(), "Empty path");
                    }
                    else
                    {
                        this.textBox2.Text = fileName;
                        this.pictureBox1.Image = Image.FromFile(fileName);
                        MessageBox.Show("Result:" + result.ToString(), "OK");
                    }
                }
            }
            else
            {
                MessageBox.Show("Result:" + result.ToString(), "Open failed");
            }

        }
        
    }
}