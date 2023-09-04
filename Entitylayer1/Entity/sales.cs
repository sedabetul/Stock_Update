using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using codeFirstStok.Entity;
using Entitylayer1.Entity;

namespace Entitylayer1.Entity
{
    public class sales
    {
        [Key]
        public int p_code { get; set; } //urun kod
        public string p_name { get; set; }//urun ad
        public int p_price { get; set; }//urun fıyat

        public string p_category { get; set; } //urun kategori
        public int p_stok { get; set; } //urun stoktaki adeti

        public ICollection<category> category { get; set; }   // <sınıf ismi> database adı
        public ICollection<stock> stocks { get; set; }
        public ICollection<wallet> wallet { get; set; }


    }
}
