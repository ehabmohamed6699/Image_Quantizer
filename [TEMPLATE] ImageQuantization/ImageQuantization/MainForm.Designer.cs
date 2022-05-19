namespace ImageQuantization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGaussSmooth = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClustersNumber_label = new System.Windows.Forms.Label();
            this.ClustersNumber_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dc_label = new System.Windows.Forms.Label();
            this.dc_number_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mse_time_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clustering_time_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.total_time_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mst_total_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(281, 526);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(191, 76);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantized Image";
            // 
            // btnGaussSmooth
            // 
            this.btnGaussSmooth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussSmooth.Location = new System.Drawing.Point(811, 526);
            this.btnGaussSmooth.Margin = new System.Windows.Forms.Padding(4);
            this.btnGaussSmooth.Name = "btnGaussSmooth";
            this.btnGaussSmooth.Size = new System.Drawing.Size(184, 76);
            this.btnGaussSmooth.TabIndex = 5;
            this.btnGaussSmooth.Text = "Quantize";
            this.btnGaussSmooth.UseVisualStyleBackColor = true;
            this.btnGaussSmooth.Click += new System.EventHandler(this.btnGaussSmooth_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(193, 569);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(75, 27);
            this.txtHeight.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(193, 517);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(75, 27);
            this.txtWidth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 577);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 456);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(628, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 456);
            this.panel2.TabIndex = 16;
            // 
            // ClustersNumber_label
            // 
            this.ClustersNumber_label.AutoSize = true;
            this.ClustersNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClustersNumber_label.Location = new System.Drawing.Point(530, 484);
            this.ClustersNumber_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClustersNumber_label.Name = "ClustersNumber_label";
            this.ClustersNumber_label.Size = new System.Drawing.Size(173, 25);
            this.ClustersNumber_label.TabIndex = 18;
            this.ClustersNumber_label.Text = "Clusters Number";
            // 
            // ClustersNumber_textbox
            // 
            this.ClustersNumber_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClustersNumber_textbox.Location = new System.Drawing.Point(526, 519);
            this.ClustersNumber_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.ClustersNumber_textbox.Name = "ClustersNumber_textbox";
            this.ClustersNumber_textbox.Size = new System.Drawing.Size(183, 30);
            this.ClustersNumber_textbox.TabIndex = 19;
            this.ClustersNumber_textbox.TextChanged += new System.EventHandler(this.ClustersNumber_textbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // dc_label
            // 
            this.dc_label.AutoSize = true;
            this.dc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.dc_label.Location = new System.Drawing.Point(149, 632);
            this.dc_label.Name = "dc_label";
            this.dc_label.Size = new System.Drawing.Size(185, 25);
            this.dc_label.TabIndex = 21;
            this.dc_label.Text = "# of Distinct Colors: ";
            this.dc_label.Click += new System.EventHandler(this.label8_Click);
            // 
            // dc_number_label
            // 
            this.dc_number_label.AutoSize = true;
            this.dc_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.dc_number_label.Location = new System.Drawing.Point(340, 632);
            this.dc_number_label.Name = "dc_number_label";
            this.dc_number_label.Size = new System.Drawing.Size(46, 25);
            this.dc_number_label.TabIndex = 22;
            this.dc_number_label.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label8.Location = new System.Drawing.Point(580, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "MST Function Execution Time in ms: ";
            // 
            // mse_time_label
            // 
            this.mse_time_label.AutoSize = true;
            this.mse_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.mse_time_label.Location = new System.Drawing.Point(946, 632);
            this.mse_time_label.Name = "mse_time_label";
            this.mse_time_label.Size = new System.Drawing.Size(46, 25);
            this.mse_time_label.TabIndex = 24;
            this.mse_time_label.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label9.Location = new System.Drawing.Point(580, 670);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(382, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Clustering Function Execution Time in ms: ";
            // 
            // clustering_time_label
            // 
            this.clustering_time_label.AutoSize = true;
            this.clustering_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.clustering_time_label.Location = new System.Drawing.Point(1017, 670);
            this.clustering_time_label.Name = "clustering_time_label";
            this.clustering_time_label.Size = new System.Drawing.Size(46, 25);
            this.clustering_time_label.TabIndex = 26;
            this.clustering_time_label.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label10.Location = new System.Drawing.Point(580, 710);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total Execution Time in ms: ";
            // 
            // total_time_label
            // 
            this.total_time_label.AutoSize = true;
            this.total_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.total_time_label.Location = new System.Drawing.Point(893, 710);
            this.total_time_label.Name = "total_time_label";
            this.total_time_label.Size = new System.Drawing.Size(46, 25);
            this.total_time_label.TabIndex = 28;
            this.total_time_label.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label11.Location = new System.Drawing.Point(149, 685);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "MST Total:";
            // 
            // mst_total_label
            // 
            this.mst_total_label.AutoSize = true;
            this.mst_total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.mst_total_label.Location = new System.Drawing.Point(276, 685);
            this.mst_total_label.Name = "mst_total_label";
            this.mst_total_label.Size = new System.Drawing.Size(46, 25);
            this.mst_total_label.TabIndex = 30;
            this.mst_total_label.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 778);
            this.Controls.Add(this.mst_total_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.total_time_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clustering_time_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mse_time_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dc_number_label);
            this.Controls.Add(this.dc_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClustersNumber_textbox);
            this.Controls.Add(this.ClustersNumber_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnGaussSmooth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Image Quantization...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGaussSmooth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClustersNumber_label;
        private System.Windows.Forms.TextBox ClustersNumber_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dc_label;
        private System.Windows.Forms.Label dc_number_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mse_time_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label clustering_time_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label total_time_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mst_total_label;
    }
}

