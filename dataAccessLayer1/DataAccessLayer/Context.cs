using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entity framework u dahil ettik

using Entitylayer1.Entity;


// tablo oluşturma işemleri için bu sınıf

namespace dataAccessLayer1.DataAccessLayer
{
    class Context:DbContext
    {
        public DbSet<stock> stocks { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<wallet> wallets { get; set; }

       
    }
}
