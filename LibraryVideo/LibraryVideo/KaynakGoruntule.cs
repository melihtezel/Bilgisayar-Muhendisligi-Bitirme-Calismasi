using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class KaynakGoruntule : Form
    {
        static string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
        static string databaseName = "test";
        static string collectionName = "kaynaks";

        static IMongoClient client = new MongoClient(connectionString);
        static IMongoDatabase db = client.GetDatabase(databaseName);
        IMongoCollection<Kaynak> kaynaklar = db.GetCollection<Kaynak>(collectionName);

        
        public KaynakGoruntule()
        {
            InitializeComponent();
        }
        public void dbYukle()
        {
            var filter = Builders<Kaynak>.Filter.Empty;
            var projection = Builders<Kaynak>.Projection.Exclude("img").Exclude("pdf"); 

            var yeniKaynaklar = kaynaklar.Find(filter).Project<Kaynak>(projection).SortBy(k => k.baslik).ToList();

           
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("baslik");
            dataTable.Columns.Add("yazar");
            dataTable.Columns.Add("kaynakturu");
            dataTable.Columns.Add("dil");
            dataTable.Columns.Add("basimYili");
            dataTable.Columns.Add("ciltNo");
            dataTable.Columns.Add("baskiNo");

            foreach (var kaynak in yeniKaynaklar)
            {
                dataTable.Rows.Add(
                    kaynak.Id,
                    kaynak.baslik,
                    kaynak.yazar,
                    kaynak.kaynakturu,
                    kaynak.dil,
                    kaynak.basimYili,
                    kaynak.ciltNo,
                    kaynak.baskiNo
                );
            }

            dataGridView1.DataSource = dataTable;
           
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            dbYukle();                      
                        
            
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtBaslik.Text = string.Empty;
            txtYazar.Text = string.Empty;
            cmbTur.Text = string.Empty;
            txtDil.Text = string.Empty;
            txtBasimYili.Text = string.Empty;
            txtCilt.Text = string.Empty;
            txtBaski.Text = string.Empty;
        }
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                var filter = Builders<Kaynak>.Filter.Regex("baslik", new BsonRegularExpression(txtBookName.Text));
                var Kaynak = kaynaklar.Find(filter).ToList();
                dataGridView1.DataSource = Kaynak;
            }
            else
            {
                dbYukle();
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            

            if (MessageBox.Show("Güncellenecek. Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
            string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                
            var filter = Builders<Kaynak>.Filter.Eq(k => k.Id, id );
                
            var update = Builders<Kaynak>.Update.Set(k => k.baslik, txtBaslik.Text).Set(k => k.yazar, txtYazar.Text)
            .Set(k => k.kaynakturu, cmbTur.Text).Set(k => k.dil, txtDil.Text).Set(k => k.basimYili, txtBasimYili.Text)
            .Set(k => k.ciltNo, txtCilt.Text).Set(k => k.baskiNo, txtBaski.Text);

            kaynaklar.UpdateOne(filter,update);
            dbYukle();
            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silinecek. Onaylıyor musunuz ?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
            string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            var filter = Builders<Kaynak>.Filter.Eq(k => k.Id, id);
            
            kaynaklar.DeleteOne(filter);
            dbYukle();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBaslik.Text = dataGridView1.CurrentRow.Cells["baslik"].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells["yazar"].Value.ToString();
            cmbTur.Text = dataGridView1.CurrentRow.Cells["kaynakturu"].Value.ToString();
            txtDil.Text = dataGridView1.CurrentRow.Cells["dil"].Value.ToString();
            txtBasimYili.Text = dataGridView1.CurrentRow.Cells["basimYili"].Value.ToString();
            txtCilt.Text = dataGridView1.CurrentRow.Cells["ciltNo"].Value.ToString();
            txtBaski.Text = dataGridView1.CurrentRow.Cells["baskiNo"].Value.ToString();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
