using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    // kötü örnek. örnek ılarak Person ve PersonOperation sınıflarını inceleyebiliriz..
    public class Kisi
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }


        public Kisi[] Kisiler = new Kisi[0];
        public void KisiEkle(Kisi kisi)
        {
            Array.Resize(ref Kisiler, Kisiler.Length + 1);
            Kisiler[Kisiler.Length - 1] = kisi;
        }
    }

}