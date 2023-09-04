using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity1Layer;


namespace Entity1Layer
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
