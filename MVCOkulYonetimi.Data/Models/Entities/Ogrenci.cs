using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOkulYonetimi.Data.Models.Entities
{
    public class Ogrenci : BaseEntity
    {
        public int OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; }

    }
}
