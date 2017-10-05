using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiImageViewer
{
    public partial class MIV : Form
    {

        //Av någon anledning aktiveras endast img2 när search1 används och fastnar i en loop

        public MIV()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd1 = new OpenFileDialog();

        OpenFileDialog ofd2 = new OpenFileDialog();

        private void sBtn1_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.Multiselect = true;
            ofd1.RestoreDirectory = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {

                foreach (string file in ofd1.SafeFileNames)
                {
                    list1.Items.Add(file);
                }


                box1.Text = ofd1.FileName.Replace(ofd1.SafeFileName, "");
            }
        }
        
        

        private void sBtn2_Click(object sender, EventArgs e)
        {
            
            ofd2.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            ofd2.CheckFileExists = true;
            ofd2.Multiselect = true;
            ofd2.RestoreDirectory = true;

            if (ofd2.ShowDialog() == DialogResult.OK)
            {

                foreach (string file in ofd2.SafeFileNames)
                {
                    list2.Items.Add(file);
                }


                box2.Text = ofd2.FileName.Replace(ofd2.SafeFileName, "");
            }

        }

        private void clear1_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            list2.Items.Clear();
        }

        private void list1_Click(object sender, EventArgs e)
        {
            img1.ImageLocation = box1.Text + list1.Text;
            img1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void list2_Click(object sender, EventArgs e)
        {
            img2.ImageLocation = box2.Text + list2.Text;
            img2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        

        private void list1_KeyUp(object sender, KeyEventArgs e)
        {
            img1.ImageLocation = box1.Text + list1.Text;
            img1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void list2_KeyUp(object sender, KeyEventArgs e)
        {
            img2.ImageLocation = box2.Text + list2.Text;
            img2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
