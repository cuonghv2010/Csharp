namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Loi thieu assembly reference: https://stackoverflow.com/questions/6192518/whats-the-difference-between-using-statement-and-adding-a-reference

            //System.Windows.Forms.MessageBox.Show("Hello");
            const string message = "Hello";
            const string caption = "some title";

            DialogResult result = System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                label1.Text = "YES";
            }
            else if(result == DialogResult.No)
            {
                label1.Text = "NO";
            }
            else
            {
                label1.Text = "CANCEL";
            }
        }
    }
}