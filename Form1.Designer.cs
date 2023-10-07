namespace Lise_Sınav_Ortalama_Hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtMatematik = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.txtFen = new System.Windows.Forms.TextBox();
            this.txtSosyal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblygs1 = new System.Windows.Forms.Label();
            this.lblygs2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblygs3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblygs6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblygs5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblygs4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(131, 266);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(157, 53);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtMatematik
            // 
            this.txtMatematik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMatematik.Location = new System.Drawing.Point(245, 38);
            this.txtMatematik.Multiline = true;
            this.txtMatematik.Name = "txtMatematik";
            this.txtMatematik.Size = new System.Drawing.Size(142, 39);
            this.txtMatematik.TabIndex = 3;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurkce.Location = new System.Drawing.Point(17, 38);
            this.txtTurkce.Multiline = true;
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(103, 39);
            this.txtTurkce.TabIndex = 1;
            // 
            // txtFen
            // 
            this.txtFen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFen.Location = new System.Drawing.Point(398, 38);
            this.txtFen.Multiline = true;
            this.txtFen.Name = "txtFen";
            this.txtFen.Size = new System.Drawing.Size(84, 39);
            this.txtFen.TabIndex = 4;
            // 
            // txtSosyal
            // 
            this.txtSosyal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSosyal.Location = new System.Drawing.Point(131, 38);
            this.txtSosyal.Multiline = true;
            this.txtSosyal.Name = "txtSosyal";
            this.txtSosyal.Size = new System.Drawing.Size(103, 39);
            this.txtSosyal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "MATEMATİK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÜRKÇE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(393, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "FEN B.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "SOSYAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ygs-1";
            // 
            // lblygs1
            // 
            this.lblygs1.AutoSize = true;
            this.lblygs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs1.Location = new System.Drawing.Point(106, 104);
            this.lblygs1.Name = "lblygs1";
            this.lblygs1.Size = new System.Drawing.Size(25, 26);
            this.lblygs1.TabIndex = 10;
            this.lblygs1.Text = "0";
            // 
            // lblygs2
            // 
            this.lblygs2.AutoSize = true;
            this.lblygs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs2.Location = new System.Drawing.Point(106, 148);
            this.lblygs2.Name = "lblygs2";
            this.lblygs2.Size = new System.Drawing.Size(25, 26);
            this.lblygs2.TabIndex = 12;
            this.lblygs2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ygs-2";
            // 
            // lblygs3
            // 
            this.lblygs3.AutoSize = true;
            this.lblygs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs3.Location = new System.Drawing.Point(106, 189);
            this.lblygs3.Name = "lblygs3";
            this.lblygs3.Size = new System.Drawing.Size(25, 26);
            this.lblygs3.TabIndex = 14;
            this.lblygs3.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ygs-3";
            // 
            // lblygs6
            // 
            this.lblygs6.AutoSize = true;
            this.lblygs6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs6.Location = new System.Drawing.Point(373, 189);
            this.lblygs6.Name = "lblygs6";
            this.lblygs6.Size = new System.Drawing.Size(25, 26);
            this.lblygs6.TabIndex = 20;
            this.lblygs6.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(279, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ygs-6";
            // 
            // lblygs5
            // 
            this.lblygs5.AutoSize = true;
            this.lblygs5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs5.Location = new System.Drawing.Point(373, 148);
            this.lblygs5.Name = "lblygs5";
            this.lblygs5.Size = new System.Drawing.Size(25, 26);
            this.lblygs5.TabIndex = 18;
            this.lblygs5.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(279, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ygs-5";
            // 
            // lblygs4
            // 
            this.lblygs4.AutoSize = true;
            this.lblygs4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygs4.Location = new System.Drawing.Point(373, 104);
            this.lblygs4.Name = "lblygs4";
            this.lblygs4.Size = new System.Drawing.Size(25, 26);
            this.lblygs4.TabIndex = 16;
            this.lblygs4.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(279, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ygs-4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 368);
            this.Controls.Add(this.lblygs6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblygs5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblygs4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblygs3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblygs2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblygs1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSosyal);
            this.Controls.Add(this.txtFen);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.txtMatematik);
            this.Controls.Add(this.btnhesapla);
            this.Name = "Form1";
            this.Text = "Lise Sınav Ortalama Hesaplama ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtMatematik;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.TextBox txtFen;
        private System.Windows.Forms.TextBox txtSosyal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblygs1;
        private System.Windows.Forms.Label lblygs2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblygs3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblygs6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblygs5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblygs4;
        private System.Windows.Forms.Label label13;
    }
}

