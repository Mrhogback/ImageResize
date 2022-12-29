using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resizeimage
{
    public partial class Form1 : Form
    {
        Image Img;
        string[] exten = { ".PNG", ".JPEG", ".JPG", ".GIF" };
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < exten.Length; i++)
                comboBox.Items.Add(exten[i]); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images  | *.png;*.jpg;*.jpeg;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtslct.Text = ofd.FileName;
                Img = Image.FromFile(ofd.FileName);
                pictureBox.Image = Image.FromFile(ofd.FileName);
                Img = pictureBox.Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) 
                txtsv.Text = fbd.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(txtw.Text), h = Convert.ToInt32(txth.Text);
            Img = Resize(Img, w, h);
            ((Button)sender).Enabled = false;
            MessageBox.Show("image resized"); 
        }
        Image Zoom(Image image, Size size)
        {
            Bitmap bmp = new Bitmap(image, image.Width + (image.Width * size.Width / 100), image.Height + (image.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            
            return bmp;
        }
        Image Resize(Image image,int w,int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage (image, 0, 0, w, h);
            graphic.Dispose(); 
            return bmp; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dot = 0, slash = 0;
            for(int j=txtslct.Text.Length-1;j>=0;j--)
                if (txtslct.Text[j]=='.')
                    dot = j;
                else if (txtslct.Text[j] == '\\')
                {
                    slash= j;
                    break;
                }
            Img.Save(txtsv.Text + "\\" + txtslct.Text.Substring(slash + 1, dot - slash - 1) + exten[comboBox.SelectedIndex]);
            ((Button)sender).Enabled = false;
            MessageBox.Show("image saved");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox.Image = Zoom(Img, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox.Image!= null) 
                pictureBox.Dispose();
        }
        int scalefactor = 5;
        float Constants = 1.7f;

        
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox.Height += Convert.ToInt32(scalefactor / Constants);
            pictureBox.Width += scalefactor;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox.Height -= scalefactor;
            pictureBox.Width -= scalefactor;
        }

    }
}