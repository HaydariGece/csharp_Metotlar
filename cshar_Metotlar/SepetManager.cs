using System;
using System.Collections.Generic;
using System.Text;

namespace cshar_Metotlar
{
    class SepetManager
    {
        public void ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi "+ urun.Adi);

        }

        public void ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Sepete eklendi " + urunAdi);
        }
    }
}
