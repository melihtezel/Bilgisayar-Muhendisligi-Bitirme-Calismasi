using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;




namespace LibraryVideo
{
    public partial class Giris : Form
    {
       
        private static string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
        private static string databaseName = "test";
        private static string collectionName = "adminler";

        private MongoClient client; 
        private IMongoDatabase database; 
        private IMongoCollection<BsonDocument> collection;
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            collection = database.GetCollection<BsonDocument>(collectionName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullanıcıAdı.Text;
            string sifre = textBoxParola.Text;

            var filter = Builders<BsonDocument>.Filter.Eq("kullaniciAdi", kullaniciAdi) & Builders<BsonDocument>.Filter.Eq("sifre", sifre); // eşleştirme yapıyoruz
            var user = collection.Find(filter).FirstOrDefault(); 

            if (user != null)
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            
            textBoxKullanıcıAdı.Text = "";
            textBoxParola.Text = "";
        
    }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
