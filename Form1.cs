using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Projet_info_SOS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap(@"C:\Users\Tom ROQUAND\Desktop\balle_tennis.jpg"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var img = new Bitmap(pictureBox1.Image).ToImage<Gray, byte>()
                    .SmoothGaussian(3);
                var gray = img.ThresholdBinaryInv(new Gray(200), new Gray(255));

                //recherche des contours
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
