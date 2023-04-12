using MVCOkulYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOkulYonetimi.Business.Interfaces
{
    public interface IOgrenciManager
    {
        List<Ogrenci> HepsiniGetir();
        void Ekle(Ogrenci ogrenci);
        void Guncelle(Ogrenci ogrenci);
        void Sil(int id);
    }
}
