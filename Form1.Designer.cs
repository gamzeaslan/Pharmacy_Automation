namespace GirisSayfasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.pswordtxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.sifremiunuttumbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 770);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 192);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eczane\r\nOtomasyon \r\nSistemi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(537, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(793, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(633, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(708, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // useridtxt
            // 
            this.useridtxt.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.useridtxt.Location = new System.Drawing.Point(775, 428);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(198, 36);
            this.useridtxt.TabIndex = 9;
            // 
            // pswordtxt
            // 
            this.pswordtxt.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pswordtxt.Location = new System.Drawing.Point(775, 505);
            this.pswordtxt.Name = "pswordtxt";
            this.pswordtxt.PasswordChar = '*';
            this.pswordtxt.Size = new System.Drawing.Size(198, 36);
            this.pswordtxt.TabIndex = 10;
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.girisbtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbtn.ForeColor = System.Drawing.Color.White;
            this.girisbtn.Location = new System.Drawing.Point(632, 592);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(182, 47);
            this.girisbtn.TabIndex = 11;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.resetbtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.Location = new System.Drawing.Point(852, 592);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(182, 47);
            this.resetbtn.TabIndex = 12;
            this.resetbtn.Text = "Sıfırla";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // sifremiunuttumbtn
            // 
            this.sifremiunuttumbtn.BackColor = System.Drawing.Color.Red;
            this.sifremiunuttumbtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiunuttumbtn.ForeColor = System.Drawing.Color.White;
            this.sifremiunuttumbtn.Location = new System.Drawing.Point(998, 505);
            this.sifremiunuttumbtn.Name = "sifremiunuttumbtn";
            this.sifremiunuttumbtn.Size = new System.Drawing.Size(215, 38);
            this.sifremiunuttumbtn.TabIndex = 14;
            this.sifremiunuttumbtn.Text = "Şifremi Unuttum";
            this.sifremiunuttumbtn.UseVisualStyleBackColor = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(1228, 645);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(112, 64);
            this.exitbtn.TabIndex = 15;
            this.exitbtn.Text = "Çıkış";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GirisSayfasi.Properties.Resources.pngtree_medical_cross_and_health_pharmacy_logo_vector_template_image_148831;
            this.pictureBox2.Location = new System.Drawing.Point(649, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GirisSayfasi.Properties.Resources._169837__1_;
            this.pictureBox1.Location = new System.Drawing.Point(42, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 721);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.sifremiunuttumbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.pswordtxt);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(613, 170);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox useridtxt;
        private System.Windows.Forms.TextBox pswordtxt;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button sifremiunuttumbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

