using System.IO;

namespace IO_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const string CALIBRATION_FILE = "calibration.json"; // file calibration đọc từ file
        private void button1_Click(object sender, EventArgs e)
        {
            if(File.Exists(CALIBRATION_FILE))
            {
                string content = File.ReadAllText(CALIBRATION_FILE);
                this.textBox1.Text = content;
            }
            else
            {
                MessageBox.Show("File not found", "Information");
                File.Create(CALIBRATION_FILE);
            }
        }
    }
}