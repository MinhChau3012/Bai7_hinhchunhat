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
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnDt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(144, 151);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(109, 20);
            this.txtKq.TabIndex = 2;
            // 
            // btnDt
            // 
            this.btnDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDt.Location = new System.Drawing.Point(78, 223);
            this.btnDt.Name = "btnDt";
            this.btnDt.Size = new System.Drawing.Size(105, 52);
            this.btnDt.TabIndex = 3;
            this.btnDt.Text = "DIỆN TÍCH";
            this.btnDt.UseVisualStyleBackColor = true;
            this.btnDt.Click += new System.EventHandler(this.btnDt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chu Vi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDt);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDAI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnDt;
        private System.Windows.Forms.Button button1;
    }
}

