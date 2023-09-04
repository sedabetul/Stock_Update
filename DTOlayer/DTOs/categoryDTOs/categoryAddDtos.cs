using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOlayer.DTOs.categoryDTOs
{
    public class categoryAddDtos
    {
        [Key]
        public int categoryId { get; set; }
        public string category_name { get; set; }
    }
}
