using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ImageQuantization
{
    public partial class MainForm : Form
    {
        long Execution_Sec = 0;
        long Execution_Msec = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        RGBPixel[,] ImageMatrix;
        List<KeyValuePair<KeyValuePair<int, int>, double>> E;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
            }
            txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();
            txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();
            timer.Start();
            KeyValuePair<int,double> No_of_dist_colors = ImageOperations.MSE(ImageMatrix); // 1
            timer.Stop();
            Execution_Sec += timer.ElapsedMilliseconds / 1000;
            Execution_Msec += timer.ElapsedMilliseconds % 1000;
            mse_time_label.Text = (timer.ElapsedMilliseconds / 1000).ToString() + "s, " + (timer.ElapsedMilliseconds % 1000).ToString() + "ms";
            dc_number_label.Text = No_of_dist_colors.Key.ToString();
            mst_total_label.Text = No_of_dist_colors.Value.ToString();
        }

        private void btnGaussSmooth_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            //double sigma = double.Parse(txtGaussSigma.Text);
            //int maskSize = (int)nudMaskSize.Value;
            int K = int.Parse(ClustersNumber_textbox.Text);
            timer.Start();
            ImageMatrix = ImageOperations.Clusterring(ImageMatrix, K); // 2
            timer.Stop();
            Execution_Sec += timer.ElapsedMilliseconds / 1000;
            Execution_Msec += timer.ElapsedMilliseconds % 1000;
            clustering_time_label.Text = (timer.ElapsedMilliseconds / 1000).ToString() + "s, " + (timer.ElapsedMilliseconds % 1000).ToString() + "ms";
            total_time_label.Text = Execution_Sec.ToString() + "s, " + Execution_Msec.ToString() + "ms";
            //ImageMatrix = ImageOperations.GaussianFilter1D(ImageMatrix, maskSize, sigma);           
            ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
            Execution_Sec = 0;
            Execution_Msec = 0;
        }

        private void txtGaussSigma_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudMaskSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClustersNumber_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}