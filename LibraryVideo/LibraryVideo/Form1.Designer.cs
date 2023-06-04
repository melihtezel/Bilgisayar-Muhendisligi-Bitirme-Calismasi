namespace LibraryVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.kitapGörüntüleToolStripMenuItem,
            this.destekToolStripMenuItem,
            this.adminKayıtToolStripMenuItem,
            this.talepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapEkleToolStripMenuItem.Image")));
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.kitapEkleToolStripMenuItem.Text = "Kaynak Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kitapGörüntüleToolStripMenuItem
            // 
            this.kitapGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapGörüntüleToolStripMenuItem.Image")));
            this.kitapGörüntüleToolStripMenuItem.Name = "kitapGörüntüleToolStripMenuItem";
            this.kitapGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.kitapGörüntüleToolStripMenuItem.Text = "Kaynak Görüntüle";
            this.kitapGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kitapGörüntüleToolStripMenuItem_Click);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("destekToolStripMenuItem.Image")));
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.destekToolStripMenuItem.Text = "Destek";
            this.destekToolStripMenuItem.Click += new System.EventHandler(this.destekToolStripMenuItem_Click);
            // 
            // adminKayıtToolStripMenuItem
            // 
            this.adminKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminKayıtToolStripMenuItem.Image")));
            this.adminKayıtToolStripMenuItem.Name = "adminKayıtToolStripMenuItem";
            this.adminKayıtToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.adminKayıtToolStripMenuItem.Text = "Admin Kayıt";
            this.adminKayıtToolStripMenuItem.Click += new System.EventHandler(this.adminKayıtToolStripMenuItem_Click);
            // 
            // talepToolStripMenuItem
            // 
            this.talepToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("talepToolStripMenuItem.Image")));
            this.talepToolStripMenuItem.Name = "talepToolStripMenuItem";
            this.talepToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.talepToolStripMenuItem.Text = "Talep";
            this.talepToolStripMenuItem.Click += new System.EventHandler(this.talepToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talepToolStripMenuItem;
    }
}

