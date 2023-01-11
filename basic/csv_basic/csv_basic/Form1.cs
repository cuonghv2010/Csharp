using System.IO;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Diagnostics;

namespace csv_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteFileCSV()
        {
            //ファイル名
            //var fileName = "sample.csv";
            var fileName = @".\sample.csv"; //  絶対パスでも良い

            //書き込むテキスト
            string data = "0,1,2,3,4,5";
            try
            {
                //ファイルをオープンする
                using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
                {
   
                  sw.WriteLine(data);
                  sw.Flush(); // Dùng flush : https://www.tuyano.com/index3?id=1284003

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteFileCSV();
        }
    }
}