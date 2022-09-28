using KiyafetApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KiyafetApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PantolonController : ControllerBase
    {
        [HttpGet("listele")]
        public List<Pantolon> Listele()
        {
            return PantolonRepository.Pantolons;
        }

        [HttpPost("ekle")]
        public void Ekle(Pantolon pantolon)
        {
            int count = PantolonRepository.Pantolons.Count();
            if (count == 0)
            {
                pantolon.ID = 1;
            }
            else
            {
                pantolon.ID = PantolonRepository.Pantolons[count - 1].ID + 1;
            }
            PantolonRepository.Pantolons.Add(pantolon);

        }

        [HttpDelete("sil")]
        public void Sil(int ID)
        {
            Pantolon silinecek = PantolonRepository.Pantolons.Find(x => x.ID == ID);
            if (silinecek != null)
            {
                PantolonRepository.Pantolons.Remove(silinecek);
            }


        }

        [HttpPut("güncelle")]
        public void Guncelle(PantolonGuncelle pantolon)
        {
            foreach (var item in PantolonRepository.Pantolons)
            {
                if (item.ID == pantolon.ID)
                {
                    item.Renk = pantolon.Renk;
                    item.Beden = pantolon.Beden;
                    item.Fiyat = pantolon.Fiyat;
                    item.EnBoy = pantolon.EnBoy;
                }
            }
        }

    

        [HttpPost("Filtrele")]
        public List<Pantolon> Filtrele(PantolonFiltrele kosullar)
        {
            List<Pantolon> sonuc = new List<Pantolon>();

            foreach (var item in PantolonRepository.Pantolons)
            {
                if (item.Fiyat < kosullar.MaxFiyat && item.Fiyat > kosullar.MinFiyat && item.Beden == kosullar.Beden)
                {
                    sonuc.Add(item);
                }                                              
            }
           
                return sonuc;
        }
    }
}

