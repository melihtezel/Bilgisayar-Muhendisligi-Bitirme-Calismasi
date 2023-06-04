using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVideo
{
    public class Kaynak
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Id { get; set; }
        public string img { get; set; }
        public string pdf { get; set; }
        public string baslik { get; set; }
        public string yazar { get; set; }
        public string kaynakturu { get; set; }
        public string dil { get; set; }
        public string basimYili { get; set; }
        public string ciltNo { get; set; }
        public string baskiNo { get; set; }
        public int indirilmeSayisi { get; set; }
        public string olusturulmaTarihi { get; set; }


        public Kaynak(string img, string pdf, string baslik, string yazar, string kaynakturu, string dil, string basimYili, string ciltNo, string baskiNo, int indirilmeSayisi, String olusturulmaTarihi)
        {            
            this.img = img;
            this.pdf = pdf;
            this.baslik = baslik;
            this.yazar = yazar;
            this.kaynakturu = kaynakturu;
            this.dil = dil;
            this.basimYili = basimYili;
            this.ciltNo = ciltNo;
            this.baskiNo = baskiNo;
            this.indirilmeSayisi = indirilmeSayisi;
            this.olusturulmaTarihi = olusturulmaTarihi;
        }

        public Kaynak(string id, string img, string pdf, string baslik, string yazar, string kaynakturu, string dil, string basimYili, string ciltNo, string baskiNo, int indirilmeSayisi, String olusturulmaTarihi)
        {
            Id = id;
            this.img = img;
            this.pdf = pdf;
            this.baslik = baslik;
            this.yazar = yazar;
            this.kaynakturu = kaynakturu;
            this.dil = dil;
            this.basimYili = basimYili;
            this.ciltNo = ciltNo;
            this.baskiNo = baskiNo;
            this.indirilmeSayisi = indirilmeSayisi;
            this.olusturulmaTarihi = olusturulmaTarihi;
        }
    }
}
