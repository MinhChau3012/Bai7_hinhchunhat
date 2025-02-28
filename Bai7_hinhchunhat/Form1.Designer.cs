namespace Bai7_hinhchunhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDAI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbChuVi = new System.Windows.Forms.CheckBox();
            this.chbDienTich = new System.Windows.Forms.CheckBox();
            this.btnTinh1 = new System.Windows.Forms.Button();
            this.btnTINH2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHIỀU DÀI";
            // 
            // txtDAI
            // 
            this.txtDAI.Location = new System.Drawing.Point(144, 53);
            this.txtDAI.Name = "txtDAI";
            this.txtDAI.Size = new System.Drawing.Size(109, 20);
            this.txtDAI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "CHIỀU RỘNG";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(144, 104);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(109, 20);
            this.txtRong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "KẾT QUẢ";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(19, 196);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(105, 52);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Location = new System.Drawing.Point(408, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(16, 65);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(61, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "CHU VI";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(16, 26);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(79, 17);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "DIỆN TÍCH";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbChuVi);
            this.groupBox2.Controls.Add(this.chbDienTich);
            this.groupBox2.Location = new System.Drawing.Point(622, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // chbChuVi
            // 
            this.chbChuVi.AutoSize = true;
            this.chbChuVi.Location = new System.Drawing.Point(17, 66);
            this.chbChuVi.Name = "chbChuVi";
            this.chbChuVi.Size = new System.Drawing.Size(62, 17);
            this.chbChuVi.TabIndex = 0;
            this.chbChuVi.Text = "CHU VI";
            this.chbChuVi.UseVisualStyleBackColor = true;
            // 
            // chbDienTich
            // 
            this.chbDienTich.AutoSize = true;
            this.chbDienTich.Location = new System.Drawing.Point(17, 26);
            this.chbDienTich.Name = "chbDienTich";
            this.chbDienTich.Size = new System.Drawing.Size(80, 17);
            this.chbDienTich.TabIndex = 0;
            this.chbDienTich.Text = "DIỆN TÍCH";
            this.chbDienTich.UseVisualStyleBackColor = true;
            // 
            // btnTinh1
            // 
            this.btnTinh1.Location = new System.Drawing.Point(449, 200);
            this.btnTinh1.Name = "btnTinh1";
            this.btnTinh1.Size = new System.Drawing.Size(96, 47);
            this.btnTinh1.TabIndex = 6;
            this.btnTinh1.Text = "button2";
            this.btnTinh1.UseVisualStyleBackColor = true;
            // 
            // btnTINH2
            // 
            this.btnTINH2.Location = new System.Drawing.Point(673, 196);
            this.btnTINH2.Name = "btnTINH2";
            this.btnTINH2.Size = new System.Drawing.Size(96, 47);
            this.btnTINH2.TabIndex = 6;
            this.btnTINH2.Text = "button2";
            this.btnTINH2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "KẾT QUẢ";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(224, 199);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 13);
            this.lblKQ.TabIndex = 7;
            this.lblKQ.Text = "KẾT QUẢ";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 321);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnTINH2);
            this.Controls.Add(this.btnTinh1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDAI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDAI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbChuVi;
        private System.Windows.Forms.CheckBox chbDienTich;
        private System.Windows.Forms.Button btnTinh1;
        private System.Windows.Forms.Button btnTINH2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKQ;
    }
}

