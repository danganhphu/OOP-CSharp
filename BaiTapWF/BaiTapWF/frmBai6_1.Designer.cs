namespace BaiTapWF
{
    partial class frmBai6_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoa = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.lblSob = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TOÁN SỐ HỌC";
            // 
            // lblSoa
            // 
            this.lblSoa.AutoSize = true;
            this.lblSoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSoa.Location = new System.Drawing.Point(112, 76);
            this.lblSoa.Name = "lblSoa";
            this.lblSoa.Size = new System.Drawing.Size(104, 19);
            this.lblSoa.TabIndex = 1;
            this.lblSoa.Text = "Nhập vào số a";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblKq.Location = new System.Drawing.Point(112, 147);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(62, 19);
            this.lblKq.TabIndex = 2;
            this.lblKq.Text = "Kết quả";
            // 
            // lblSob
            // 
            this.lblSob.AutoSize = true;
            this.lblSob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSob.Location = new System.Drawing.Point(112, 112);
            this.lblSob.Name = "lblSob";
            this.lblSob.Size = new System.Drawing.Size(104, 19);
            this.lblSob.TabIndex = 3;
            this.lblSob.Text = "Nhập vào số b";
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoa.Location = new System.Drawing.Point(252, 76);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(147, 26);
            this.txtSoa.TabIndex = 4;
            this.txtSoa.TextChanged += new System.EventHandler(this.txtSoa_TextChanged);
            this.txtSoa.Leave += new System.EventHandler(this.txtSoa_Leave);
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(252, 147);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(147, 26);
            this.txtKQ.TabIndex = 5;
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSob.Location = new System.Drawing.Point(252, 112);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(147, 26);
            this.txtSob.TabIndex = 6;
            this.txtSob.Leave += new System.EventHandler(this.txtSob_Leave);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(75, 222);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(58, 35);
            this.btnCong.TabIndex = 7;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(439, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "C";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.Location = new System.Drawing.Point(158, 222);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(58, 35);
            this.btnTru.TabIndex = 11;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(535, 224);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(64, 35);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Close";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.Location = new System.Drawing.Point(341, 222);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(58, 35);
            this.btnChia.TabIndex = 13;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(252, 222);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(58, 35);
            this.btnNhan.TabIndex = 14;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // frmBai6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.lblSob);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.lblSoa);
            this.Controls.Add(this.label1);
            this.Name = "frmBai6_1";
            this.Text = "Bài 6_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoa;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Label lblSob;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
    }
}

