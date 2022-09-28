using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
namespace KiyafetApplication.Models


{
    public class PantolonGuncelle
    {
        
        public int ID { get; set; }
        public string Renk { get; set; }
        public string Beden { get; set; }
        public string EnBoy { get; set; }
        public int Fiyat { get; set; }


    }
    
    
}
