using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOkulYonetimi.Business.Repository.GenericRepositoryInterface
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> HepsiniGetir();
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(int id);
    }
}
