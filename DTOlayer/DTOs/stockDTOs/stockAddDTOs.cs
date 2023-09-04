using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOlayer.DTOs.stockDTOs
{
     public class stockAddDTOs
    {
        [Key]
        public int p_code { get; set; } //urun kod  
        public int Id { get; set; } // sonradan ekledim




        public string p_name { get; set; }//urun ad
        public int p_price { get; set; }//urun fıyat
        public string p_category { get; set; } //urun kategori
        public int p_stok { get; set; } //urun stoktaki adeti
        public int critical_stock { get; set; }//kritik stok
        public string p_pic { get; set; }//gorsel
    }
}
