using MVCOkulYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOkulYonetimi.Business.Interfaces
{
    public interface IOgretmenManager
    {
        List<Ogretmen> HepsiniGetir();
        void Ekle(Ogretmen ogretmen);
        void Guncelle(Ogretmen ogretmen);
        void Sil(int id);
    }
}
