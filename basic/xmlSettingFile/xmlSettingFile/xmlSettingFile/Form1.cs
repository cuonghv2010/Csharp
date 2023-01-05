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

        // This is the class that will be deserialized.
        public class OrderedItem
        {
            [XmlElement(Namespace = "http://www.cpandl.com")]
            public string ItemName;
            [XmlElement(Namespace = "http://www.cpandl.com")]
            public string Description;
            [XmlElement(Namespace = "http://www.cohowinery.com")]
            public decimal UnitPrice;
            [XmlElement(Namespace = "http://www.cpandl.com")]
            public int Quantity;
            [XmlElement(Namespace = "http://www.cohowinery.com")]
            public decimal LineTotal;
            // A custom method used to calculate price per item.
            public void Calculate()
            {
                LineTotal = UnitPrice * Quantity;
            }
        }

        private void DeserializeObject(string filename)
        {
            Debug.WriteLine("Reading with Stream");
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer =
            new XmlSerializer(typeof(OrderedItem));

            // Declare an object variable of the type to be deserialized.
            OrderedItem i;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (OrderedItem)serializer.Deserialize(reader);
            }

            // Write out the properties of the object.
            Debug.Write(
            i.ItemName + "\t" +
            i.Description + "\t" +
            i.UnitPrice + "\t" +
            i.Quantity + "\t" +
            i.LineTotal);
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
            Debug.WriteLine($"{result.Id}, {result.Text}");

;        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("============hello=========\n");
            const string xmlFile = @".\test.xml";
            DeserializeObject(xmlFile);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}