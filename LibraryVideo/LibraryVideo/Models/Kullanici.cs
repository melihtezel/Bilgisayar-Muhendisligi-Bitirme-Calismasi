using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVideo.Models
{
    internal class Kullanici
    {
        public string kullaniciAdi  { get; set; }
        public string sifre  { get; set; }
        public string adSoyad { get; set; }
        public string email { get; set; }
        public string olusturulmaTarihi { get; set; }

        public Kullanici(string username, string password, string fullName, string Email,string tarih)
        {
          
            adSoyad = fullName;
            email = Email;
            kullaniciAdi = username;
            sifre= password;  
            olusturulmaTarihi = tarih;
            
        }
    }
}
