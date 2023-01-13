using System.IO;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Diagnostics;
using System.Threading;

namespace csv_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] header =
        {
            "Time",
            "Value1",
            "Value2",
            "Value3"
        };

        //public float[] data = { 1.0, 2.0, 3.0];
        public int[] data = { 10, 20, 30 };
   

        private void WriteFileCSV()
        {
            //ファイル名
            //var fileName = "sample.csv";
            var SavePathName = @".\logData.csv"; //  絶対パスでも良い
            bool IsNeedToAddHeader = true;
            if (File.Exists(SavePathName)) IsNeedToAddHeader = false;
            //書き込むテキスト

            try
            {
                //ファイルをオープンする
                using (StreamWriter sw = new StreamWriter(SavePathName, true, Encoding.UTF8))
                {

                    if (IsNeedToAddHeader)
                    {
                        string aHeaderLine = string.Join(",", header);
                        sw.WriteLine(aHeaderLine);
                    }
                    string aDataLine = string.Join(",", data);
                    aDataLine = DateTime.Now.ToString("yyyyMMdd") + "," + aDataLine;
                    sw.WriteLine(aDataLine);
                    sw.Flush(); // Dùng flush : https://www.tuyano.com/index3?id=1284003

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Save data to CSV done");
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