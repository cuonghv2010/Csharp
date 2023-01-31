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
        string settingsFolder = "";
        string settingFilePath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(settingsFolder))
            {
                if (File.Exists(settingFilePath))
                {
                    string content = File.ReadAllText(settingFilePath);
                    if (content != "")
                    {
                        this.textBox1.Text = content;
                    }
                    else
                    {
                        MessageBox.Show("File empty", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("File not found", "Information");
                    File.Create(settingFilePath);
                }
            }
            else
            {
                Directory.CreateDirectory(settingsFolder);

                MessageBox.Show("Setting folder not found, creat setting folder ", "Information");
            }
            textBox2.Text = settingsFolder;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(settingFilePath))
            {
                string content = this.textBox1.Text;
                if (content != "")
                {
                    File.WriteAllText(settingFilePath, content);
                    MessageBox.Show("Saved to " + settingFilePath, "Information");
                }
                else
                {
                    MessageBox.Show("Text empty", "Information");
                }
            }
            else
            {
                MessageBox.Show("File not found", "Information");
                File.Create(CALIBRATION_FILE);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         settingsFolder = Directory.GetCurrentDirectory() + "\\settings";
         settingFilePath = settingsFolder + "\\" + CALIBRATION_FILE;
            if (Directory.Exists(settingsFolder))
            {
                if (File.Exists(settingFilePath))
                {
                    string content = File.ReadAllText(settingFilePath);
                    if (content != "")
                    {
                        this.textBox1.Text = content;
                    }
                    else
                    {
                        MessageBox.Show("File empty", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("File not found", "Information");
                    File.Create(settingFilePath);
                }
            }
            else
            {
                Directory.CreateDirectory(settingsFolder);

                MessageBox.Show("Setting folder not found, creat setting folder ", "Information");
            }
            textBox2.Text = settingsFolder;
        }
    }
}