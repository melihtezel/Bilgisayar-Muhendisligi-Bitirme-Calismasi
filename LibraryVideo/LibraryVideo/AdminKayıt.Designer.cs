namespace LibraryVideo
{
    partial class AdminKayıt
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
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxeMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxŞifre = new System.Windows.Forms.TextBox();
            this.textBoxKAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "eMail";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(188, 78);
            this.textBoxAdSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(134, 20);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // textBoxeMail
            // 
            this.textBoxeMail.Location = new System.Drawing.Point(188, 113);
            this.textBoxeMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxeMail.Name = "textBoxeMail";
            this.textBoxeMail.Size = new System.Drawing.Size(134, 20);
            this.textBoxeMail.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxŞifre
            // 
            this.textBoxŞifre.Location = new System.Drawing.Point(188, 181);
            this.textBoxŞifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxŞifre.Name = "textBoxŞifre";
            this.textBoxŞifre.PasswordChar = '*';
            this.textBoxŞifre.Size = new System.Drawing.Size(134, 20);
            this.textBoxŞifre.TabIndex = 8;
            // 
            // textBoxKAdı
            // 
            this.textBoxKAdı.Location = new System.Drawing.Point(188, 146);
            this.textBoxKAdı.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKAdı.Name = "textBoxKAdı";
            this.textBoxKAdı.Size = new System.Drawing.Size(134, 20);
            this.textBoxKAdı.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // AdminKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxŞifre);
            this.Controls.Add(this.textBoxKAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxeMail);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminKayıt";
            this.Text = "Admin Kayıt";
            this.Load += new System.EventHandler(this.AdminKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxeMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxŞifre;
        private System.Windows.Forms.TextBox textBoxKAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}