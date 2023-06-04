using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MongoDB.Bson;
using System.Collections.ObjectModel;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Net;

namespace LibraryVideo
{
    public partial class Destek : Form
    {
        private IMongoCollection<BsonDocument> collection;
        public Destek()
        {
            InitializeComponent();
            
            string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
            string databaseName = "test";
            string collectionName = "tickets";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<BsonDocument>(collectionName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Destek_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mail= "hik.beykent@hotmail.com", pw= "Hik123456";

            SmtpClient istemci = new SmtpClient("smtp-mail.outlook.com",587)
            {
                EnableSsl = true,
                Credentials=new NetworkCredential(mail,pw)
            };

            istemci.SendMailAsync(new MailMessage("hik.beykent@hotmail.com", textBox1.Text, textBox2.Text, richTextBox1.Text));

            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                string selectedId = dataGridView1.SelectedRows[0].Cells["_id"].Value.ToString();

               
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(selectedId));
                var update = Builders<BsonDocument>.Update.Set("cevapDurumu", "Evet");

                collection.UpdateOne(filter, update);

                
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            

            

        }

        private void LoadDataToDataGridView()
        {
           
            var documents = collection.Find(new BsonDocument()).ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("_id");
            dataTable.Columns.Add("email");
            dataTable.Columns.Add("konu");
            dataTable.Columns.Add("sorun");
            dataTable.Columns.Add("cevapDurumu");
            dataTable.Columns.Add("olusturulmaTarihi");

            foreach (var document in documents)
            {
                var row = dataTable.NewRow();
                row["_id"] = document.GetValue("_id").ToString();
                row["email"] = document.GetValue("email").ToString();
                row["konu"] = document.GetValue("konu").ToString();
                row["sorun"] = document.GetValue("sorun").ToString();
                row["cevapDurumu"] = document.GetValue("cevapDurumu").ToString();
                row["olusturulmaTarihi"] = document.GetValue("olusturulmaTarihi").ToString();
                dataTable.Rows.Add(row);
            }

           
            dataGridView1.DataSource = dataTable;
        }

        private void DestekLoad(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["email"].Index && e.RowIndex >= 0)
            {
                
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();

                
                textBox1.Text = selectedValue;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["konu"].Index && e.RowIndex >= 0)
            {
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells["konu"].Value.ToString();

                
                textBox2.Text = selectedValue;
            }


            

            if (e.ColumnIndex == dataGridView1.Columns["sorun"].Index && e.RowIndex >= 0)
            {
               
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells["sorun"].Value.ToString();

               
                richTextBox2.Text = selectedValue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
    }
    }

