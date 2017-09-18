using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiddenWordsLibrary;

namespace HiddenWords
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void convertButton_click(object sender, EventArgs e)
        {
            outputLabel.Text = Functions.StringToHex(InputBox.Text);
        }

        private void pictureBrowseButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap loadedPic = new Bitmap(openFileDialog1.FileName);
                LoadedPictureTest.Image = loadedPic;
            }
        }
    }
}
