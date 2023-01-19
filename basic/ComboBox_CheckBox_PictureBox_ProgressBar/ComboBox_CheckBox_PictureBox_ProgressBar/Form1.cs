namespace ComboBox_CheckBox_PictureBox_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int progress = (int)numericUpDown1.Value;
            if (progress > progressBar1.Maximum) progress = progressBar1.Maximum;
            if (progress < progressBar1.Minimum) progress = progressBar1.Minimum;
            progressBar1.Value = progress;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int progress = (int) trackBar1.Value;
            if (progress > progressBar1.Maximum) progress = progressBar1.Maximum;
            if (progress < progressBar1.Minimum) progress = progressBar1.Minimum;
            progressBar1.Value = progress;
        }
    }
}