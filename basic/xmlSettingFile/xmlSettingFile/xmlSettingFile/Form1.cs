using System.IO;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Diagnostics;

namespace xmlSettingFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Sample
        {
            public int Id { get; set; }
            public string Text { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // シリアライズ先のファイル
            const string xmlFile = @".\Sample.xml";
            // シリアライズするオブジェクト
            var obj = new Sample { Id = 7, Text = "＠IT" }; // （1）

            // シリアライズする
            var xmlSerializer1 = new XmlSerializer(typeof(Sample));
            using (var streamWriter = new StreamWriter(xmlFile, false, Encoding.UTF8))
            {
                xmlSerializer1.Serialize(streamWriter, obj);
                streamWriter.Flush();
            }

            // デシリアライズする
            var xmlSerializer2 = new XmlSerializer(typeof(Sample));
            Sample result;
            var xmlSettings = new System.Xml.XmlReaderSettings()
            {
                CheckCharacters = false, // （2）
            };
            using (var streamReader = new StreamReader(xmlFile, Encoding.UTF8))
            using (var xmlReader
                    = System.Xml.XmlReader.Create(streamReader, xmlSettings))
            {
                result = (Sample)xmlSerializer2.Deserialize(xmlReader); // （3）
            }
            label1.Text = result.Text;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}