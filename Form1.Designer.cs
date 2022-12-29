namespace resizeimage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtslct = new System.Windows.Forms.TextBox();
            this.txtsv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtw = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilih Gambar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simpan Gambar";
            // 
            // txtslct
            // 
            this.txtslct.Location = new System.Drawing.Point(269, 40);
            this.txtslct.Name = "txtslct";
            this.txtslct.Size = new System.Drawing.Size(430, 31);
            this.txtslct.TabIndex = 2;
            // 
            // txtsv
            // 
            this.txtsv.Location = new System.Drawing.Point(269, 110);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(430, 31);
            this.txtsv.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // txtw
            // 
            this.txtw.Location = new System.Drawing.Point(922, 34);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(150, 31);
            this.txtw.TabIndex = 9;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(922, 98);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(150, 31);
            this.txth.TabIndex = 10;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(922, 162);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(150, 33);
            this.comboBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(858, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "RESIZE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(983, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 13;
            this.button4.Text = "SAVE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(157, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(425, 253);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(269, 162);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(358, 69);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(89, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 444);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsv);
            this.Controls.Add(this.txtslct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PengubahUkuranGambar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtslct;
        private TextBox txtsv;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtw;
        private TextBox txth;
        private ComboBox comboBox;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox;
        private TrackBar trackBar1;
        private Panel panel1;
        private Button btnZoomIn;
        private Button btnZoomOut;
    }
}