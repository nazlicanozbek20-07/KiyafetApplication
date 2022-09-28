using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyafetApplication.Models
{
    public class Kazak : IKiyafet
    {
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public string Yaka { get; set; }
        public string Beden { get; set; }
        public string Desen { get; set; }
        public string Ozellik1 { get; set; }
        public int Fiyat { get; set; }
        public List<Renkler> Renkler { get; set; }

        public Kazak()
        {
            Renkler = new List<Renkler>();
            Renkler.Add(Models.Renkler.Kirmizi);
            Renkler.Add(Models.Renkler.Gri);
            Renkler.Add(Models.Renkler.Beyaz);
            Renkler.Add(Models.Renkler.Siyah);
        }

        public decimal MaliyetHesapla(int adet)
        {
            return adet * Fiyat;
        }

        public bool RenkMevcutMu(Renkler renkler)
        {
            foreach (Renkler renk in Renkler)
            {
                if (renk == renkler)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
