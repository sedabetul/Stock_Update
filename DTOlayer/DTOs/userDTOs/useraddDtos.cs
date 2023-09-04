using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOlayer.DTOs.userDTOs
{
  public class useraddDtos
    {
        [Key]
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_password { get; set; }
        public int u_authority { get; set; }
        public string u_money { get; set; }
        public string u_mail { get; set; }
    }
}
