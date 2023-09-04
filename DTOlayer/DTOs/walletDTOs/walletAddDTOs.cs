using Entity1Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOlayer.DTOs.walletDTOs
{
    public class walletAddDTOs
    {
        [Key]
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_money { get; set; }
        public string u_mail { get; set; }
        public user user { get; set; }
        public sales sales { get; set; }

    }
}
