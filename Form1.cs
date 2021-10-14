using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uploadandSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void uploadImageFile_Click(object sender, EventArgs e)
        {

            // pictureBox pictureBox = new pictureBox();
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    textBox1.Text = ofd.FileName;
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //FileDialog.Equals(textBox1.Text,path.combind("C:\Users\User\OneDrive - University of Derby\Documents\2020-2021 university of derby\year 1\programming II\exercises and reading note and solutions\my codes\uploadandSave\uploadandSave\images"))             //.copy(textBox1)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

