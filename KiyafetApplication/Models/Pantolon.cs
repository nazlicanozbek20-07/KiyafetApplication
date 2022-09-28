using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KiyafetApplication.Models
{
    public class Pantolon : IKiyafet
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public string Beden { get; set; }
        public string EnBoy { get; set; }
        public int Fiyat { get; set; }
        public string Kesim { get; set; }
        public string Marka { get; set; }
        public bool PacaYapilacakMi { get; set; }
        public string Kumas { get; set; }
        [JsonIgnore]
        public List<Renkler> Renkler { get; set; }



        public Pantolon()

        {
            Renkler = new List<Renkler>()
            {
                Models.Renkler.Siyah,
                Models.Renkler.Gri
            };
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
