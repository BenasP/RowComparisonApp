using System;
using System.IO;
using System.Windows.Forms;

namespace RowComparisonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
                                             {
                                                 InitialDirectory = "c:\\",
                                                 Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                                                 FilterIndex = 1,
                                                 RestoreDirectory = true
                                             };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CompareFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void CompareFilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(CompareFilePathTextBox.Text))
            {
                CompareButton.Enabled = true;
                return;
            }
            CompareButton.Enabled = false;
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {

        }
    }
}
