using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyafetApplication.Models
{
    public interface IKiyafet
    {
        public int ID { get; set; }
        string Tur { get; set; }
        string Renk { get; set; }
        string Beden { get; set; }
        int Fiyat { get; set; }

        List<Renkler> Renkler { get; set; }

        decimal MaliyetHesapla(int adet);

        bool RenkMevcutMu(Renkler renkler);


    }

}
