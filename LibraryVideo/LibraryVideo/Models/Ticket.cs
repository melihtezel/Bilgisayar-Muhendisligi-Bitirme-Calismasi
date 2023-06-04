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
    public class Ticket
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Id { get; set; }
        public string email { get; set; }
        public string konu { get; set; }
        public string sorun { get; set; }
        public string cevapDurumu { get; set; }
        public string olusturulmaTarihi { get; set; }

        public Ticket(string id, string email, string konu, string sorun, string cevapDurumu, string olusturulmaTarihi)
        {
            this.Id = id;
            this.email = email;
            this.konu = konu;
            this.sorun = sorun;
            this.cevapDurumu = cevapDurumu;
            this.olusturulmaTarihi = olusturulmaTarihi;
        }


        public Ticket(string email, string konu, string sorun, string cevapDurumu, string olusturulmaTarihi)
        {            
            this.email = email;
            this.konu = konu;
            this.sorun = sorun;
            this.cevapDurumu = cevapDurumu;
            this.olusturulmaTarihi = olusturulmaTarihi;
        }
    }
}
