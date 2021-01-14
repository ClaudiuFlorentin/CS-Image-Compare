namespace fingerprint_imgcompare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.path2 = new System.Windows.Forms.TextBox();
            this.path1 = new System.Windows.Forms.TextBox();
            this.buttonOpen1 = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.headerBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpen2 = new System.Windows.Forms.Button();
            this.pictureBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxImg2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.headerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // path2
            // 
            this.path2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path2.Enabled = false;
            this.path2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.path2.Location = new System.Drawing.Point(72, 83);
            this.path2.Multiline = true;
            this.path2.Name = "path2";
            this.path2.ReadOnly = true;
            this.path2.Size = new System.Drawing.Size(311, 27);
            this.path2.TabIndex = 3;
            // 
            // path1
            // 
            this.path1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path1.Enabled = false;
            this.path1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.path1.Location = new System.Drawing.Point(72, 51);
            this.path1.Multiline = true;
            this.path1.Name = "path1";
            this.path1.ReadOnly = true;
            this.path1.Size = new System.Drawing.Size(311, 27);
            this.path1.TabIndex = 6;
            // 
            // buttonOpen1
            // 
            this.buttonOpen1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen1.FlatAppearance.BorderSize = 0;
            this.buttonOpen1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.buttonOpen1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOpen1.Location = new System.Drawing.Point(389, 51);
            this.buttonOpen1.Name = "buttonOpen1";
            this.buttonOpen1.Size = new System.Drawing.Size(75, 27);
            this.buttonOpen1.TabIndex = 7;
            this.buttonOpen1.Text = "Open";
            this.buttonOpen1.UseVisualStyleBackColor = false;
            this.buttonOpen1.Click += new System.EventHandler(this.buttonOpenAction1);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(201)))));
            this.buttonCompare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(201)))));
            this.buttonCompare.FlatAppearance.BorderSize = 0;
            this.buttonCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.buttonCompare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.buttonCompare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCompare.Location = new System.Drawing.Point(353, 115);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(111, 27);
            this.buttonCompare.TabIndex = 8;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompareAction);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_________________________________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerBar
            // 
            this.headerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerBar.Controls.Add(this.pictureBox1);
            this.headerBar.Controls.Add(this.button1);
            this.headerBar.Controls.Add(this.label4);
            this.headerBar.Controls.Add(this.buttonExit);
            this.headerBar.Location = new System.Drawing.Point(-2, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(482, 31);
            this.headerBar.TabIndex = 10;
            this.headerBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerBar_Down);
            this.headerBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerBar_Move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(418, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "−";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMinimizeAction);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(44, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image Compare";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExit.Location = new System.Drawing.Point(450, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExitAction);
            // 
            // buttonOpen2
            // 
            this.buttonOpen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen2.FlatAppearance.BorderSize = 0;
            this.buttonOpen2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpen2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonOpen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.buttonOpen2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOpen2.Location = new System.Drawing.Point(389, 83);
            this.buttonOpen2.Name = "buttonOpen2";
            this.buttonOpen2.Size = new System.Drawing.Size(75, 27);
            this.buttonOpen2.TabIndex = 11;
            this.buttonOpen2.Text = "Open";
            this.buttonOpen2.UseVisualStyleBackColor = false;
            this.buttonOpen2.Click += new System.EventHandler(this.buttonOpenAction2);
            // 
            // pictureBoxImg1
            // 
            this.pictureBoxImg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImg1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxImg1.Location = new System.Drawing.Point(52, 188);
            this.pictureBoxImg1.Name = "pictureBoxImg1";
            this.pictureBoxImg1.Size = new System.Drawing.Size(154, 184);
            this.pictureBoxImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg1.TabIndex = 12;
            this.pictureBoxImg1.TabStop = false;
            // 
            // pictureBoxImg2
            // 
            this.pictureBoxImg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImg2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxImg2.Location = new System.Drawing.Point(275, 188);
            this.pictureBoxImg2.Name = "pictureBoxImg2";
            this.pictureBoxImg2.Size = new System.Drawing.Size(154, 184);
            this.pictureBoxImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg2.TabIndex = 13;
            this.pictureBoxImg2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(106, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Image 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(330, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Image 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 393);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxImg2);
            this.Controls.Add(this.pictureBoxImg1);
            this.Controls.Add(this.buttonOpen2);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonOpen1);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headerBar.ResumeLayout(false);
            this.headerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path2;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.Button buttonOpen1;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpen2;
        private System.Windows.Forms.PictureBox pictureBoxImg1;
        private System.Windows.Forms.PictureBox pictureBoxImg2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

