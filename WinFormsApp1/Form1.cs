namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void introductionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, My name is Miranda Barnes!");
        }

        private void objectionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am determined to master C#!!");
        }

        private void motivationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onward and upward, whatever it takes!");
        }
    }
}