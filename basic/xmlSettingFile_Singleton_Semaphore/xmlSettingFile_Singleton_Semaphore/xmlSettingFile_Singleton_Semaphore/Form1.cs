using System.IO;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace xmlSettingFile_Singleton_Semaphore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GSC = GenericSettingsCtrl.Instance;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("============Load setting data=========\n");
            GSC.LoadDataFromXml();
            showSettingElements();
        }

        private GenericSettingsCtrl GSC;    // ��{�ݒ�I�u�W�F�N�g�ւ̎Q��(Singleton)

        public class GenericSettingsCtrl
        {
            /// <summary>
            /// Singleton Object : Parameters refers to "GenericSettings.xml"
            /// </summary>
            private static readonly Lazy<GenericSettingsCtrl> _instance =
                new Lazy<GenericSettingsCtrl>(() =>
                {
                    // Lazy<T> �ɂ�� Singleton ��`�����Ă���ꍇ�Aconstructor �I�ȓ���͂�����œ��삷��

                    return new GenericSettingsCtrl();
                });

            /// <summary>
            /// ���̃N���X�� Singleton ��`�̂��߁A���̂̊m�ۂ� new �ł͂Ȃ����̃��\�b�h���Ăяo���ĉ�����
            /// </summary>
            public static GenericSettingsCtrl Instance
            {
                get { return _instance.Value; }
            }

            /// <summary>
            /// constructor : Singleton ��`�N���X�̂��ߌ��J����܂���
            /// </summary>
            private GenericSettingsCtrl()
            {
                // �����ʒu�Ƃ��Ă̐ݒ�t�@�C�� Path ��ێ�
                SettingFileFullPath = Directory.GetCurrentDirectory() + SettingsFileDefaultName;
                // �f�[�^�{�̂��܂��쐬
                GSD = new GenericSettingsData();
            }

            public const string SettingsFileDefaultName = @".\setting.xml";
            private string SettingFileFullPath = string.Empty;

            public GenericSettingsData GSD = null;

            private void loadDataFromxmlSettingFile(string FileFullPath)
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
            private void SaveDataToxmlSettingFile(string FileFullPath)
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
                    serializer.Serialize(fs, GSD);
                }
            }
            public void SetSettingFileFullPath(string path) { SettingFileFullPath = path; }

            public void SaveDataToXml()
            {
                SaveDataToxmlSettingFile(SettingFileFullPath);
            }

            public void LoadDataFromXml()
            {
                loadDataFromxmlSettingFile(SettingFileFullPath);
            }

        }

        [XmlRootAttribute("GenericSettings")]
        public class GenericSettingsData
        {
            [XmlElement("Element1")] public string Element1;
            [XmlElement("Element2")] public string Element2;
            [XmlElement("Element3")] public string Element3;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("============Load setting data=========\n");
            //loadDataFromxmlSettingFile_Singleton_Semaphore(FileFullPath);
            showSettingElements();
        }

        private void showSettingElements()
        {
            tbxElement1.Text = GSC.GSD.Element1;
            tbxElement2.Text = GSC.GSD.Element2;
            tbxElement3.Text = GSC.GSD.Element3;
        }
        private void updateSettingElements()
        {
            GSC.GSD.Element1 = tbxElement1.Text;
            GSC.GSD.Element2 = tbxElement2.Text;
            GSC.GSD.Element3 = tbxElement3.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("============Save setting data=========\n");
            updateSettingElements();
            GSC.SaveDataToXml();
        }
    }
}