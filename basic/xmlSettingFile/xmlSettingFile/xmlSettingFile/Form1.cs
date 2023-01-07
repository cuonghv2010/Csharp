using System.IO;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace xmlSettingFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("============Load setting data=========\n");
            loadDataFromXmlSettingFile(FileFullPath);
            showSettingElements();
        }

        [XmlRootAttribute("GenericSettings")]
        public class GenericSettingsData
        {
            [XmlElement("Element1")] public string Element1;
            [XmlElement("Element2")] public string Element2;
            [XmlElement("Element3")] public string Element3;

        }

        private string FileFullPath = @".\setting.xml"; 
        public GenericSettingsData GSD = null;

        private void loadDataFromXmlSettingFile(string FileFullPath)
        {
            Debug.WriteLine("Reading with Stream");

            FileStream fs = null;

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(GenericSettingsData));
            // Su dung using: https://xuanthulab.net/stream-trong-c-lam-viec-voi-filestream-lap-trinh-c-sharp.html
            // https://xuanthulab.net/su-dung-giao-dien-idisposable-va-tu-khoa-using-trong-c-sharp.html
            // 
            using (fs = new FileStream(FileFullPath, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                GSD = (GenericSettingsData)serializer.Deserialize(fs);
            }
            /*
            Debug.Write(
            GSD.Element1 + "\t" +
            GSD.Element2 + "\t" +
            GSD.Element3);
            */
        }
        private void SaveDataToXmlSettingFile(string FileFullPath)
        {
            Debug.WriteLine("Save with Stream");

            FileStream fs = null;

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(GenericSettingsData));
            // Su dung using: https://xuanthulab.net/stream-trong-c-lam-viec-voi-filestream-lap-trinh-c-sharp.html
            // https://xuanthulab.net/su-dung-giao-dien-idisposable-va-tu-khoa-using-trong-c-sharp.html
            // 
            using (fs = new FileStream(FileFullPath, FileMode.Create))
            {
                serializer.Serialize(fs,GSD);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("============Load setting data=========\n");
            loadDataFromXmlSettingFile(FileFullPath);
            showSettingElements();
        }

        private void showSettingElements()
        {
            tbxElement1.Text = GSD.Element1;
            tbxElement2.Text = GSD.Element2;
            tbxElement3.Text = GSD.Element3;
        }
        private void updateSettingElements()
        {
            GSD.Element1 = tbxElement1.Text;
            GSD.Element2 = tbxElement2.Text;           
            GSD.Element3 = tbxElement3.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("============Save setting data=========\n");
            updateSettingElements();
            SaveDataToXmlSettingFile(FileFullPath);
        }
    }
}