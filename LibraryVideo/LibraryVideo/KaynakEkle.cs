using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace LibraryVideo
{
    public partial class KaynakEkle : Form
    {

       
        static string connectionString = "mongodb+srv://beykent:beykent@cluster0.sicshak.mongodb.net/";
        static string databaseName = "test";
        static string collectionName = "kaynaks";

        static IMongoClient client = new MongoClient(connectionString); 
        static IMongoDatabase db = client.GetDatabase(databaseName); 
        IMongoCollection<Kaynak> kaynaklar = db.GetCollection<Kaynak>(collectionName); 
       

        public string imgDondur()
        {
            string[] imgL = {
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/a.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/b.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/c.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/d.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/e.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/f.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/g.png",
                   "https://raw.githubusercontent.com/SalihSarii/HIK/main/public/uploads/h.png"

        };
            Random random = new Random();

            return imgL[random.Next(0, 8)];
            
        }

        public string pdfDondur()
        {
            string[] pdfL = {
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapA.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/c661efe83ddf74e9349e5f0538f7161d8a0b66dc/public/uploads/kitaplar/kitapB.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapC.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapD.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapE.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapF.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapG.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapH.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapI.pdf",
                    "https://raw.githubusercontent.com/SalihSarii/HIK/1c5644184c0799fa3a68833d29334a9a31a332d2/public/uploads/kitaplar/kitapJ.pdf"
            };

            Random random = new Random();

            return pdfL[random.Next(0, 10)];
           
        }

        public KaynakEkle()
        {
            InitializeComponent(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtBaslik.Text != "" && txtYazar.Text != "" && cmbTur.SelectedIndex != -1 && txtDil.Text != "" && txtBasimYili.Text != "" && txtCilt.Text != "" && txtBaski.Text != "")
            {
                string img = imgDondur();
                string pdf = pdfDondur();
                string tarih = DateTime.Now.ToString();


                Kaynak yeniKaynak = new Kaynak(
                    img,
                    pdf,
                    txtBaslik.Text,
                    txtYazar.Text,
                    cmbTur.Text,
                    txtDil.Text,
                    txtBasimYili.Text,
                    txtCilt.Text,
                    txtBaski.Text,  
                    0,
                    tarih
                );


                kaynaklar.InsertOne(yeniKaynak);


                MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaslik.Clear();
                txtYazar.Clear();                
                txtCilt.Clear();
                txtBasimYili.Clear();
                txtDil.Clear();
                txtBaski.Clear();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Veri Silinecek Onaylıyor Musunuz", "Emin Misiniz?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void txtPublication_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
