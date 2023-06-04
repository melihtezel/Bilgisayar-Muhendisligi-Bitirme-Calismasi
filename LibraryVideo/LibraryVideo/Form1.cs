using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaynakEkle abs = new KaynakEkle();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaynakGoruntule vb = new KaynakGoruntule();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaynakEkle abs = new KaynakEkle();
            abs.Show();
        }

        private void kitapGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaynakGoruntule vb = new KaynakGoruntule();
            vb.Show();
        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destek dk = new Destek();
            dk.Show();
        }

        private void adminKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AdminKayıt admin = new AdminKayıt();
            admin.Show();
        }

        private void talepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Talep talep = new Talep();
            talep.Show();
        }
    }
}
