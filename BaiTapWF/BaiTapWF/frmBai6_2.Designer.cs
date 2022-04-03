namespace BaiTapWF
{
    partial class frmBai6_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdpt2 = new System.Windows.Forms.RadioButton();
            this.rdpt1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.lblSoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdpt2);
            this.groupBox1.Controls.Add(this.rdpt1);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Phương Trình";
            // 
            // rdpt2
            // 
            this.rdpt2.AutoSize = true;
            this.rdpt2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdpt2.Location = new System.Drawing.Point(17, 72);
            this.rdpt2.Name = "rdpt2";
            this.rdpt2.Size = new System.Drawing.Size(159, 25);
            this.rdpt2.TabIndex = 3;
            this.rdpt2.TabStop = true;
            this.rdpt2.Text = "ax^2 + bx + c = 0";
            this.rdpt2.UseVisualStyleBackColor = true;
            this.rdpt2.CheckedChanged += new System.EventHandler(this.rdpt2_CheckedChanged);
            // 
            // rdpt1
            // 
            this.rdpt1.AutoSize = true;
            this.rdpt1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdpt1.Location = new System.Drawing.Point(17, 37);
            this.rdpt1.Name = "rdpt1";
            this.rdpt1.Size = new System.Drawing.Size(103, 25);
            this.rdpt1.TabIndex = 2;
            this.rdpt1.TabStop = true;
            this.rdpt1.Text = "ax + b = 0";
            this.rdpt1.UseVisualStyleBackColor = true;
            this.rdpt1.CheckedChanged += new System.EventHandler(this.rdpt1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giải Phương Trình";
            // 
            // txtSoc
            // 
            this.txtSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoc.Location = new System.Drawing.Point(433, 148);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(125, 26);
            this.txtSoc.TabIndex = 13;
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSob.Location = new System.Drawing.Point(433, 110);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(125, 26);
            this.txtSob.TabIndex = 12;
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoa.Location = new System.Drawing.Point(433, 73);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(125, 26);
            this.txtSoa.TabIndex = 11;
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSoc.Location = new System.Drawing.Point(346, 153);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(60, 16);
            this.lblSoc.TabIndex = 10;
            this.lblSoc.Text = "Hệ số c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(345, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hệ số b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(346, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hệ số a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetqua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(212, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Enabled = false;
            this.txtKetqua.Location = new System.Drawing.Point(3, 23);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(295, 91);
            this.txtKetqua.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnclear.Location = new System.Drawing.Point(551, 381);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(91, 31);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.AllowDrop = true;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDong.Location = new System.Drawing.Point(344, 381);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 31);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThuchien
            // 
            this.btnThuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchien.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThuchien.Location = new System.Drawing.Point(117, 381);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(91, 31);
            this.btnThuchien.TabIndex = 15;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // frmBai6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSoc);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.lblSoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai6_2";
            this.Text = "Bài 6_2";
            this.Load += new System.EventHandler(this.frmBai6_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdpt2;
        private System.Windows.Forms.RadioButton rdpt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThuchien;
    }
}