using LibraryVideo.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class AdminKayıt : Form
    {
        public AdminKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

             string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
             string databaseName = "test";
             string collectionName = "adminler"; 

             IMongoClient client = new MongoClient(connectionString);
             IMongoDatabase db = client.GetDatabase(databaseName);
             IMongoCollection<Kullanici> collection = db.GetCollection<Kullanici>(collectionName); 
            


            string username = textBoxKAdı.Text;
            string password = textBoxŞifre.Text;
            string fullName = textBoxAdSoyad.Text;
            string Email = textBoxeMail.Text;
            string tarih = DateTime.Now.ToString(); 

            
            Kullanici Yenikullanici = new Kullanici(username, password, fullName, Email, tarih);

            
            collection.InsertOne(Yenikullanici);

            MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AdminKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
