﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity1Layer;





namespace Entity1Layer
{
    public class wallet
    {
        [Key]
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_money { get; set; }
        public string u_mail { get; set; }
        public user user { get; set; }
        public sales sales { get; set; }

        public ICollection<stock> stocks { get; set; }

    }
}
