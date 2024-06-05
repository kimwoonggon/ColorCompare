namespace ColorCompare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUploadImage1;
        private System.Windows.Forms.Button btnUploadImage2;
        private System.Windows.Forms.Button btnUploadImage3;
        private System.Windows.Forms.Button btnDeleteImage1;
        private System.Windows.Forms.Button btnDeleteImage2;
        private System.Windows.Forms.Button btnDeleteImage3;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label labelPixelInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUploadImage1 = new System.Windows.Forms.Button();
            this.btnUploadImage2 = new System.Windows.Forms.Button();
            this.btnUploadImage3 = new System.Windows.Forms.Button();
            this.btnDeleteImage1 = new System.Windows.Forms.Button();
            this.btnDeleteImage2 = new System.Windows.Forms.Button();
            this.btnDeleteImage3 = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.labelPixelInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnUploadImage1
            // 
            this.btnUploadImage1.Location = new System.Drawing.Point(3, 3);
            this.btnUploadImage1.Name = "btnUploadImage1";
            this.btnUploadImage1.Size = new System.Drawing.Size(100, 30);
            this.btnUploadImage1.TabIndex = 3;
            this.btnUploadImage1.Text = "Upload Image 1";
            this.btnUploadImage1.UseVisualStyleBackColor = true;
            this.btnUploadImage1.Click += new System.EventHandler(this.btnUploadImage1_Click);
            // 
            // btnUploadImage2
            // 
            this.btnUploadImage2.Location = new System.Drawing.Point(109, 3);
            this.btnUploadImage2.Name = "btnUploadImage2";
            this.btnUploadImage2.Size = new System.Drawing.Size(100, 30);
            this.btnUploadImage2.TabIndex = 4;
            this.btnUploadImage2.Text = "Upload Image 2";
            this.btnUploadImage2.UseVisualStyleBackColor = true;
            this.btnUploadImage2.Click += new System.EventHandler(this.btnUploadImage2_Click);
            // 
            // btnUploadImage3
            // 
            this.btnUploadImage3.Location = new System.Drawing.Point(215, 3);
            this.btnUploadImage3.Name = "btnUploadImage3";
            this.btnUploadImage3.Size = new System.Drawing.Size(100, 30);
            this.btnUploadImage3.TabIndex = 5;
            this.btnUploadImage3.Text = "Upload Image 3";
            this.btnUploadImage3.UseVisualStyleBackColor = true;
            this.btnUploadImage3.Click += new System.EventHandler(this.btnUploadImage3_Click);
            // 
            // btnDeleteImage1
            // 
            this.btnDeleteImage1.Location = new System.Drawing.Point(109, 3);
            this.btnDeleteImage1.Name = "btnDeleteImage1";
            this.btnDeleteImage1.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteImage1.TabIndex = 6;
            this.btnDeleteImage1.Text = "X";
            this.btnDeleteImage1.UseVisualStyleBackColor = true;
            this.btnDeleteImage1.Click += new System.EventHandler(this.btnDeleteImage1_Click);
            // 
            // btnDeleteImage2
            // 
            this.btnDeleteImage2.Location = new System.Drawing.Point(215, 3);
            this.btnDeleteImage2.Name = "btnDeleteImage2";
            this.btnDeleteImage2.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteImage2.TabIndex = 7;
            this.btnDeleteImage2.Text = "X";
            this.btnDeleteImage2.UseVisualStyleBackColor = true;
            this.btnDeleteImage2.Click += new System.EventHandler(this.btnDeleteImage2_Click);
            // 
            // btnDeleteImage3
            // 
            this.btnDeleteImage3.Location = new System.Drawing.Point(321, 3);
            this.btnDeleteImage3.Name = "btnDeleteImage3";
            this.btnDeleteImage3.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteImage3.TabIndex = 8;
            this.btnDeleteImage3.Text = "X";
            this.btnDeleteImage3.UseVisualStyleBackColor = true;
            this.btnDeleteImage3.Click += new System.EventHandler(this.btnDeleteImage3_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(427, 3);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(100, 30);
            this.btnErase.TabIndex = 9;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // labelPixelInfo
            // 
            this.labelPixelInfo.AutoSize = true;
            this.labelPixelInfo.Location = new System.Drawing.Point(533, 0);
            this.labelPixelInfo.Name = "labelPixelInfo";
            this.labelPixelInfo.Size = new System.Drawing.Size(72, 17);
            this.labelPixelInfo.TabIndex = 10;
            this.labelPixelInfo.Text = "Pixel Info: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 260);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(269, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 260);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(535, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 260);
            this.panel3.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 266);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnUploadImage1);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteImage1);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadImage2);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteImage2);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadImage3);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteImage3);
            this.flowLayoutPanel1.Controls.Add(this.btnErase);
            this.flowLayoutPanel1.Controls.Add(this.labelPixelInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 266);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 34);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Image Pixel Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

