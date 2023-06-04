using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class Talep : Form
    {
        string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
            string databaseName = "test";
            string collectionName = "taleps";
        public Talep()
        {
            InitializeComponent();

            
        }

        private void Talep_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            
            var documents = collection.Find(new BsonDocument()).ToList();

            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("baslik");
            dataTable.Columns.Add("yazar");
            dataTable.Columns.Add("kaynakTuru");
            dataTable.Columns.Add("baskiNo");
            dataTable.Columns.Add("olusturulmaTarihi");

          
            foreach (var document in documents)
            {
                dataTable.Rows.Add(
                    document["_id"].ToString(),
                    document["baslik"].ToString(),
                    document["yazar"].ToString(),
                    document["kaynakturu"].ToString(),
                    document["baskiNo"].ToString(),
                    document["olusturulmaTarihi"].ToString()
                );
            }

           
            dataGridView1.DataSource = dataTable;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
