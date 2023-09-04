using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Entity_Layer.Entity
{
    public class category
    {
        [Key] 
        public int categoryId { get; set; }
        public string category_name{ get; set; }

        public ICollection<stock> stocks { get; set; }   // <sınıf ismi>  adı
        public ICollection<sales> sales { get; set; }
    }
}
