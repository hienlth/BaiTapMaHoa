namespace BaiTapMaHoa
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
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtChuoiNhap = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.khoa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.Location = new System.Drawing.Point(114, 81);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 26);
            this.txtK.TabIndex = 0;
            // 
            // txtChuoiNhap
            // 
            this.txtChuoiNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiNhap.Location = new System.Drawing.Point(114, 115);
            this.txtChuoiNhap.Name = "txtChuoiNhap";
            this.txtChuoiNhap.Size = new System.Drawing.Size(378, 26);
            this.txtChuoiNhap.TabIndex = 1;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Location = new System.Drawing.Point(508, 76);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(80, 44);
            this.btnMaHoa.TabIndex = 2;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // khoa
            // 
            this.khoa.AutoSize = true;
            this.khoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoa.Location = new System.Drawing.Point(24, 89);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(45, 18);
            this.khoa.TabIndex = 3;
            this.khoa.Text = "Khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuỗi nhập";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Location = new System.Drawing.Point(508, 154);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(80, 44);
            this.btnGiaiMa.TabIndex = 5;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(114, 164);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(378, 26);
            this.txtKetQua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chuỗi xuất";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 227);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtChuoiNhap);
            this.Controls.Add(this.txtK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtChuoiNhap;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Label khoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
    }
}

